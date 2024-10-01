/* This file was copied / derived under the following license:
 * 
 * Licensed to the .NET Foundation under one or more agreements.
 * The .NET Foundation licenses this file to you under the MIT license.
 */

namespace System.Runtime.CompilerServices;

#if !NETCOREAPP3_0_OR_GREATER && !NET5_0_OR_GREATER

/// <summary>
///   Indicates that a parameter captures the expression passed for another parameter as a string.
/// </summary>
/// <param name="parameterName">The name of the parameter whose expression should be captured as a string.</param>
/// <remarks><b>
///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
///   The actual implementation is only provided in .NET Core 3.0/later and .NET 5.0/later.
///</b></remarks>
[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
public sealed class CallerArgumentExpressionAttribute(string parameterName) : Attribute
{
   #region Properties
   /// <summary>Gets the name of the parameter whose expression should be captured as a string.</summary>
   /// <returns>The name of the parameter whose expression should be captured.</returns>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET Core 3.0/later and .NET 5.0/later.
   ///</b></remarks>
   public string ParameterName { get; } = parameterName;
   #endregion
}

#endif
