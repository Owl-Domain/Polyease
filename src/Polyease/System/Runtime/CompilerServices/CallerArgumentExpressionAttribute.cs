namespace System.Runtime.CompilerServices;

// Todo(Nightowl): Replace the OwlDomain.Polyease comments with a link to the package/repository;

#if !NETCOREAPP3_0_OR_GREATER && !NET5_0_OR_GREATER

/// <summary>
/// Indicates that a parameter captures the expression passed for another parameter as a string.
/// </summary>
/// <remarks><b>
///   This is a stub provided by the OwlDomain.Polyease package.<br/>
///   The actual implementation is only provided in .NET Core 3.0/later and .NET 5.0/later.
///</b></remarks>
[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
public sealed class CallerArgumentExpressionAttribute : Attribute
{
#pragma warning disable IDE0290 // Use primary constructor
   /// <summary>Initializes a new instance of the <see cref="CallerArgumentExpressionAttribute"/> class.</summary>
   /// <param name="parameterName">The name of the parameter whose expression should be captured as a string.</param>
   /// <remarks><b>
   ///   This is a stub provided by the OwlDomain.Polyease package.<br/>
   ///   The actual implementation is only provided in .NET Core 3.0/later and .NET 5.0/later.
   ///</b></remarks>
   public CallerArgumentExpressionAttribute(string parameterName)
   {
      ParameterName = parameterName;
   }
#pragma warning restore IDE0290 // Use primary constructor

   /// <summary>Gets the name of the parameter whose expression should be captured as a string.</summary>
   /// <returns>The name of the parameter whose expression should be captured.</returns>
   /// <remarks><b>
   ///   This is a stub provided by the OwlDomain.Polyease package.<br/>
   ///   The actual implementation is only provided in .NET Core 3.0/later and .NET 5.0/later.
   ///</b></remarks>
   public string ParameterName { get; }
}

#endif