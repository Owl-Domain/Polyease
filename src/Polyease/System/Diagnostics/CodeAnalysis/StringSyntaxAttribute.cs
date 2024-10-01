/* This file was copied / derived under the following license:
 * 
 * Licensed to the .NET Foundation under one or more agreements.
 * The .NET Foundation licenses this file to you under the MIT license.
 */

namespace System.Diagnostics.CodeAnalysis;

#if !NET7_0_OR_GREATER

/// <summary>Specifies the syntax used in a string.</summary>
/// <remarks><b>
///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
///   The actual implementation is only provided in .NET 7.0/later.
///</b></remarks>
[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public sealed class StringSyntaxAttribute : Attribute
{
   #region Constants
   /// <summary>The syntax identifier for strings containing composite formats for string formatting.</summary>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public const string CompositeFormat = nameof(CompositeFormat);

   /// <summary>The syntax identifier for strings containing date format specifiers.</summary>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public const string DateOnlyFormat = nameof(DateOnlyFormat);

   /// <summary>The syntax identifier for strings containing date and time format specifiers.</summary>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public const string DateTimeFormat = nameof(DateTimeFormat);

   /// <summary>The syntax identifier for strings containing <see cref="Enum"/> format specifiers.</summary>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public const string EnumFormat = nameof(EnumFormat);

   /// <summary>The syntax identifier for strings containing <see cref="Guid"/> format specifiers.</summary>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public const string GuidFormat = nameof(GuidFormat);

   /// <summary>The syntax identifier for strings containing JavaScript Object Notation (JSON).</summary>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public const string Json = nameof(Json);

   /// <summary>The syntax identifier for strings containing numeric format specifiers.</summary>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public const string NumericFormat = nameof(NumericFormat);

   /// <summary>The syntax identifier for strings containing regular expressions.</summary>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public const string Regex = nameof(Regex);

   /// <summary>The syntax identifier for strings containing time format specifiers.</summary>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public const string TimeOnlyFormat = nameof(TimeOnlyFormat);

   /// <summary>The syntax identifier for strings containing <see cref="TimeSpan"/> format specifiers.</summary>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public const string TimeSpanFormat = nameof(TimeSpanFormat);

   /// <summary>The syntax identifier for strings containing URIs.</summary>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public const string Uri = nameof(Uri);

   /// <summary>The syntax identifier for strings containing XML.</summary>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public const string Xml = nameof(Xml);
   #endregion

   #region Properties
   /// <summary>Gets the identifier of the syntax used.</summary>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public string Syntax { get; }

   /// <summary>Optional arguments associated with the specific syntax employed.</summary>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public object?[] Arguments { get; }
   #endregion

   #region Constructors
   /// <summary>Initializes the <see cref="StringSyntaxAttribute"/> with the identifier of the syntax used.</summary>
   /// <param name="syntax">The syntax identifier.</param>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public StringSyntaxAttribute(string syntax)
   {
      Syntax = syntax;
      Arguments = [];
   }

   /// <summary>Initializes the <see cref="StringSyntaxAttribute"/> with the identifier of the syntax used.</summary>
   /// <param name="syntax">The syntax identifier.</param>
   /// <param name="arguments">Optional arguments associated with the specific syntax employed.</param>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public StringSyntaxAttribute(string syntax, params object?[] arguments)
   {
      Syntax = syntax;
      Arguments = arguments;
   }
   #endregion
}

#endif
