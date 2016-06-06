# Pre-Adamant Compiler

In order to bootstrap the Adamant compiler, a compiler for the Pre-Adamant language is being written in C#.  The first version of the Adamant compiler will then be written in Pre-Adamant.  Pre-Adamant is a simplified, reduced feature version of the Adamant language.

## Project Status: Alpha Active
This is under active development.  It is in a very early stage and there are likely issues and limitations.  APIs are subject to frequent breaking changes.

### Download and Use
Clone this git repo and compile using Visual Studio 2015.

## Pre-Adamant Language Features

The Pre-Adamant Language is a modified form of the Adamant 1.0 Language.  The sections below describe the differences.

### Undecided for Pre-Adamant

It is still undecided whether the following features of Adamant will be included in Pre-Adamant.

Feature      | Description
--------------------------
Operator Overloading |
Properties |
Overload Number of Parameters |
Contract Parsing | i.e. `requires` and `ensures`
Re-declaring Variable Bindings |
`params` Keyword |
`unsafe` Support |

### Excluded from Pre-Adamant

Descriptions in this section describe the behavior of Pre-Adamant with regards to the feature of Adamant.

Feature      | Description
-------------|------------
Doc Comments | Documentation comments are not distinguished from regular comments in any way.
Yield | `yield` keyword used to easily write methods returning iterators is treated as a reserved word.
Bitwise Operations | All bitwise operations on numbers are not supported, but the operators are reserved.
Partial Classes |
Fixed Point Types | All fixed*.* types are reserved words.
Decimal Types | All decimal* types are reserved words.
128 Bit Types | The types `float128`, `int128` and `uint128` are reserved words.
Overload Functions on Argument Types | Functions can't be overload on the type of their arguments.
Type Inference | Type inference is not done, all types must be fully simplified.
Ownership Inference | Ownership inference is not done, all ownership/lifetimes must be fully simplified.
Contract Execution | The `requires` and `ensures` contracts will not be enforced at compile time or runtime.
Constant Folding and Static Execution | i.e. at compile time
`unchecked` Contexts | `unchecked` is a reserved word.

### Included in Pre-Adamant

Generally any feature of Adamant that isn't specifically excluded from Pre-Adamant is included.  However, there are a few features that for various reasons it seems appropriate to call out as included in Pre-Adamant.

Feature      | Description
-------------|------------
Reserved Words | Any keyword of Adamant that is part of a feature that is excluded is a reserved word in Pre-Adamant.
Escaped Identifiers | Identifiers escaped with a backtick