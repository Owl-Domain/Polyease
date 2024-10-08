/* This file was copied / derived under the following license:
 * 
 * Licensed to the .NET Foundation under one or more agreements.
 * The .NET Foundation licenses this file to you under the MIT license.
 */

namespace System.Diagnostics;

#if !NET7_0_OR_GREATER

/// <summary>
/// Exception thrown when the program executes an instruction that was thought to be unreachable.
/// </summary>
/// <remarks><b>
///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
///   The actual implementation is only provided in .NET 7.0/later.
///</b></remarks>
public sealed class UnreachableException : Exception
{
   #region Constructors
   /// <summary>
   ///   Initializes a new instance of the <see cref="UnreachableException"/> class with the default error message.
   /// </summary>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public UnreachableException() : base("The program executed an instruction that was thought to be unreachable.") { }

   /// <summary>
   ///   Initializes a new instance of the <see cref="UnreachableException"/>
   ///   class with a specified error message.
   /// </summary>
   /// <param name="message">The error message that explains the reason for the exception.</param>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public UnreachableException(string? message) : base(message ?? "The program executed an instruction that was thought to be unreachable.") { }

   /// <summary>
   ///   Initializes a new instance of the <see cref="UnreachableException"/>
   ///   class with a specified error message and a reference to the inner exception that is the cause of
   ///   this exception.
   /// </summary>
   /// <param name="message">The error message that explains the reason for the exception.</param>
   /// <param name="innerException">The exception that is the cause of the current exception.</param>
   /// <remarks><b>
   ///   This is a stub provided by the <see href="https://github.com/Owl-Domain/Polyease">OwlDomain.Polyease</see> package.<br/>
   ///   The actual implementation is only provided in .NET 7.0/later.
   ///</b></remarks>
   public UnreachableException(string? message, Exception? innerException) : base(message ?? "The program executed an instruction that was thought to be unreachable.", innerException) { }
   #endregion
}

#endif
