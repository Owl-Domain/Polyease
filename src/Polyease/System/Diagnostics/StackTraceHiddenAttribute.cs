/* This file was copied / derived under the following license:
 * 
 * Licensed to the .NET Foundation under one or more agreements.
 * The .NET Foundation licenses this file to you under the MIT license.
 */

namespace System.Diagnostics;

#if !NET6_0_OR_GREATER

/// <summary>
///   Types and Methods attributed with <see cref="StackTraceHiddenAttribute"/> will be omitted from the
///   stack trace text shown in <see cref="StackTrace.ToString"/> and <see cref="Exception.StackTrace"/>.
/// </summary>
/// <remarks><b>
///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
///   The actual implementation is only provided in .NET 6.0/later.
///</b></remarks>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Struct, Inherited = false)]
public sealed class StackTraceHiddenAttribute : Attribute { }

#endif
