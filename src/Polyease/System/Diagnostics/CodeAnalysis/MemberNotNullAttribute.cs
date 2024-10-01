/* This file was copied / derived under the following license:
 * 
 * Licensed to the .NET Foundation under one or more agreements.
 * The .NET Foundation licenses this file to you under the MIT license.
 */

namespace System.Diagnostics.CodeAnalysis;

#if !NET5_0_OR_GREATER

/// <summary>
///   Specifies that the method or property will ensure that 
///   the listed field and property members have not-null values.
/// </summary>
/// <remarks><b>
///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
///   The actual implementation is only provided in .NET 5.0/later.
///</b></remarks>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
public sealed class MemberNotNullAttribute : Attribute
{
   #region Properties
   /// <summary>Gets field or property member names.</summary>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 5.0/later.
   ///</b></remarks>
   public string[] Members { get; }
   #endregion

   #region Constructors
   /// <summary>Initializes the attribute with a field or property member.</summary>
   /// <param name="member">
   /// The field or property member that is promised to be not-null.
   /// </param>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 5.0/later.
   ///</b></remarks>
   public MemberNotNullAttribute(string member) => Members = [member];

   /// <summary>Initializes the attribute with the list of field and property members.</summary>
   /// <param name="members">
   /// The list of field and property members that are promised to be not-null.
   /// </param>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 5.0/later.
   ///</b></remarks>
   public MemberNotNullAttribute(params string[] members) => Members = members;
   #endregion
}

#endif
