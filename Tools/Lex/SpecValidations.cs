using System;
using System.Collections.Generic;
using System.Linq;
using static PreAdamant.Compiler.Tools.Lex.SpecParser;

namespace PreAdamant.Compiler.Tools.Lex
{
	internal class SpecValidations : SpecParserBaseListener
	{
		private readonly IReadOnlyDictionary<string, Spec> imports;
		private bool inModesBlock;
		private readonly ISet<string> ruleNames = new HashSet<string>();
		private ISet<string> channels;

		public SpecValidations(Dictionary<string, Spec> imports)
		{
			this.imports = imports;
		}

		public override void EnterModesDirective(ModesDirectiveContext context)
		{
			inModesBlock = true;
		}

		public override void ExitModesDirective(ModesDirectiveContext context)
		{
			inModesBlock = false;
		}

		public override void EnterNameDirective(NameDirectiveContext context)
		{
			if(inModesBlock)
				throw new Exception("@lexer directive can't occur inside @modes block");
		}

		public override void EnterNamespaceDirective(NamespaceDirectiveContext context)
		{
			if(inModesBlock)
				throw new Exception("@namespace directive can't occur inside @modes block");
		}

		public override void EnterImportDirective(ImportDirectiveContext context)
		{
			if(inModesBlock)
				throw new Exception("@import directive can't occur inside @modes block");
		}

		public override void EnterStartModeDirective(StartModeDirectiveContext context)
		{
			if(inModesBlock)
				throw new Exception("@startMode directive can't occur inside @modes block");
		}

		public override void EnterIncludeDirective(IncludeDirectiveContext context)
		{
			if(!inModesBlock)
				throw new Exception("@include directive can only occur inside @modes block");
		}

		public override void EnterChannelsDirective(ChannelsDirectiveContext context)
		{
			if(inModesBlock)
				throw new Exception("@channels directive can't occur inside @modes block");

			if(channels != null)
				throw new Exception("Only one @channels directive per specification");

			channels = new HashSet<string>(context._channels.Select(t => t.Text));
		}

		public override void EnterParseRule(ParseRuleContext context)
		{
			var name = context.name.Text;
			var isFragement = char.IsLower(name[0]);
			if(inModesBlock && isFragement)
				throw new Exception($"Fragement '{name}' not allowed inside @modes block");
			if(!inModesBlock && !isFragement)
				throw new Exception($"Rule '{name}' not allowed outside @modes block");

			if(ruleNames.Contains(name))
				throw new Exception($"Rule {name} defined more than once");

			ruleNames.Add(name);

			if(isFragement)
			{
				if(context.@base != null)
					throw new Exception($"Fragment '{name}' has a base token, fragements are not allowed to have base tokens");
				if(context.pattern() == null)
					throw new Exception($"Fragment '{name}' does not have a pattern");
				if(context._commands != null && context._commands.Any())
					throw new Exception($"Fragment '{name}' has commands");
			}
		}

		public override void EnterChannelCommand(ChannelCommandContext context)
		{
			var channel = context.channel.Text;
			if(channels == null)
				throw new Exception($"Channel '{channel}' used without being declared with @channels or before @channels directive");

			if(!channels.Contains(channel))
				throw new Exception($"Channel '{channel}' used, but not declared with @channels");
		}

		public override void EnterActionCommand(ActionCommandContext context)
		{
			var parseRule = (ParseRuleContext)context.Parent;
			if(parseRule._commands.IndexOf(context) != parseRule._commands.Count - 1)
				throw new Exception("@action command must be the last command in a command list");
		}
	}
}
