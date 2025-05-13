namespace SimpleC.Base.Standard
{
    /// <summary>
    /// This enumeration will mark major versions of the ANSI C, or ISO C Standard. Some
    /// text will be added to explain, at a high level, the point of these releases. The
    /// actual target for our example will be older C (C89), which will be explained in
    /// the documentation. This is primarily taken from the Wikipedia entry; and needs
    /// other sources (see documentation).
    /// </summary>
    public enum ISOCStandard
    {
        /// <summary>
        /// (1989) The ANSI standard was completed in 1989 and ratified as ANSI X3.159-1989 "Programming Language C." 
        /// This version of the language is often referred to as "ANSI C". Later on sometimes the label "C89" is used 
        /// to distinguish it from C90 but using the same labeling method. 
        /// </summary>
        C89,

        /// <summary>
        /// (1990) The same standard as C89 was ratified by ISO/IEC as ISO/IEC 9899:1990, with only formatting changes, 
        /// which is sometimes referred to as C90.Therefore, the terms "C89" and "C90" refer to a language that is virtually 
        /// identical.This standard has been withdrawn by both ANSI/INCITS[4] and ISO/IEC.
        /// </summary>
        C90,

        /// <summary>
        /// In 1995, the ISO/IEC published an extension, called Amendment 1, for the C standard. Its full name finally was 
        /// ISO/IEC 9899:1990/AMD1:1995 or nicknamed C95. Aside from error correction there were further changes to the 
        /// language capabilities, such as: Improved multi-byte and wide character support in the standard library, 
        /// introducing <wchar.h> and <wctype.h> as well as multi-byte I/O Addition of digraphs to the language specification 
        /// of standard macros for the alternative specification of operators, e.g. and for && Specification of the standard 
        /// macro __STDC_VERSION__ In addition to the amendment, two technical corrigenda were published by ISO for C90:ISO/IEC 
        /// 9899:1990/Cor 1:1994 TCOR1 in 1994 ISO/IEC 9899:1990/Cor 2:1996 in 1996
        /// 
        /// Preprocessor test for C95 compatibility
        ///
        ///     #if defined(__STDC_VERSION__) && __STDC_VERSION__ >= 199409L
        ///
        ///     /* C95 compatible source code. */
        ///     #elif defined(__STDC__)
        ///     /* C89 compatible source code. */
        ///     #endif
        /// </summary>
        C95,

        /// <summary>
        /// (1999) In March 2000, ANSI adopted the ISO/IEC 9899:1999 standard. This standard is commonly referred to as C99.
        ///        Some notable additions to the previous standard include:
        /// 
        ///        New built-in data types: long long, _Bool, _Complex, and _Imaginary. 
        ///        
        ///        Several new core language features, including static array indices, designated initializers, compound literals, 
        ///        variable-length arrays, flexible array members, variadic macros, and restrict keyword. Several new library headers, 
        ///        including stdint.h, <tgmath.h>, fenv.h, <complex.h> Improved compatibility with several C++ features, including 
        ///        inline functions, single-line comments with //, mixing declarations and code, and universal character names in 
        ///        identifiers. Removed several dangerous C89 language features such as implicit function declarations and implicit int.
        ///
        ///        Three technical corrigenda were published by ISO for C99:
        ///
        ///           ISO/IEC 9899:1999/Cor 1:2001(E)
        ///           ISO/IEC 9899:1999/Cor 2:2004(E)
        ///           ISO/IEC 9899:1999/Cor 3:2007(E), notable for deprecating the standard library function gets
        ///         
        ///        This standard has been withdrawn by both ANSI/INCITS[11] and ISO/IEC[12] in favour of C11.
        /// </summary>
        C99,


        /// <summary>
        /// (2011) C11 was officially ratified and published on December 8, 2011. Notable features include improved Unicode support, 
        ///        type-generic expressions using the new _Generic keyword, a cross-platform multi-threading API(threads.h), and atomic 
        ///        types support in both core language and the library(stdatomic.h). One technical corrigendum has been published by 
        ///        ISO for C11: ISO/IEC 9899:2011/Cor 1:2012.
        /// </summary>
        C11,

        /// <summary>
        /// (2017) C17 was published in June 2018. Rather than introducing new language features, it only addresses defects in C11.
        /// </summary>
        C17,

        /// <summary>
        /// (2023) C23 was published in October 2024, and is the current standard for the C programming language.
        /// </summary>
        C23
    }
}
