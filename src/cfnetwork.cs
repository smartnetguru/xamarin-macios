//
// cfnetwork.cs: Definitions for CFNetwork
//
// Copyright 2014-2015 Xamarin Inc. All rights reserved.
//

using System;
using XamCore.Foundation;
using XamCore.ObjCRuntime;

// Both CFHttpStream and CFHTTPMessage are in CFNetwork.framework, no idea why they ended up in CoreServices when they were bound.
#if XAMCORE_4_0
namespace XamCore.CFNetwork {
#else
namespace XamCore.CoreServices {
#endif

	[Partial]
	interface CFHTTPStream {

		[Availability (Deprecated = Platform.iOS_9_0 | Platform.Mac_10_11)]
		[Internal][Field ("kCFStreamPropertyHTTPAttemptPersistentConnection", "CFNetwork")]
		NSString _AttemptPersistentConnection { get; }

		[Availability (Deprecated = Platform.iOS_9_0 | Platform.Mac_10_11)]
		[Internal][Field ("kCFStreamPropertyHTTPFinalURL", "CFNetwork")]
		NSString _FinalURL { get; }

		[Availability (Deprecated = Platform.iOS_9_0 | Platform.Mac_10_11)]
		[Internal][Field ("kCFStreamPropertyHTTPFinalRequest", "CFNetwork")]
		NSString _FinalRequest { get; }

		[Availability (Deprecated = Platform.iOS_9_0 | Platform.Mac_10_11)]
		[Internal][Field ("kCFStreamPropertyHTTPProxy", "CFNetwork")]
		NSString _Proxy { get; }

		[Availability (Deprecated = Platform.iOS_9_0 | Platform.Mac_10_11)]
		[Internal][Field ("kCFStreamPropertyHTTPRequestBytesWrittenCount", "CFNetwork")]
		NSString _RequestBytesWrittenCount { get; }

		[Availability (Deprecated = Platform.iOS_9_0 | Platform.Mac_10_11)]
		[Internal][Field ("kCFStreamPropertyHTTPResponseHeader", "CFNetwork")]
		NSString _ResponseHeader { get; }

		[Availability (Deprecated = Platform.iOS_9_0 | Platform.Mac_10_11)]
		[Internal][Field ("kCFStreamPropertyHTTPShouldAutoredirect", "CFNetwork")]
		NSString _ShouldAutoredirect { get; }
	}

	[Partial]
	interface CFHTTPMessage {

		[Internal][Field ("kCFHTTPVersion1_0", "CFNetwork")]
		NSString _HTTPVersion1_0 { get; }

		[Internal][Field ("kCFHTTPVersion1_1", "CFNetwork")]
		NSString _HTTPVersion1_1 { get; }

		[Mac (10,11)][iOS (9,0)]
		[Internal][Field ("kCFHTTPVersion2_0", "CFNetwork")]
		NSString _HTTPVersion2_0 { get; }

		[Internal][Field ("kCFHTTPAuthenticationSchemeBasic", "CFNetwork")]
		NSString _AuthenticationSchemeBasic { get; }

		[Internal][Field ("kCFHTTPAuthenticationSchemeNegotiate", "CFNetwork")]
		NSString _AuthenticationSchemeNegotiate { get; }

		[Internal][Field ("kCFHTTPAuthenticationSchemeNTLM", "CFNetwork")]
		NSString _AuthenticationSchemeNTLM { get; }

		[Internal][Field ("kCFHTTPAuthenticationSchemeDigest", "CFNetwork")]
		NSString _AuthenticationSchemeDigest { get; }

		[Internal][Field ("kCFHTTPAuthenticationUsername", "CFNetwork")]
		NSString _AuthenticationUsername { get; }

		[Internal][Field ("kCFHTTPAuthenticationPassword", "CFNetwork")]
		NSString _AuthenticationPassword { get; }

		[Internal][Field ("kCFHTTPAuthenticationAccountDomain", "CFNetwork")]
		NSString _AuthenticationAccountDomain { get; }

		// misdocumented by Apple (feedback left)
		// OSX headers says it's 10.9 only
		// iOS headers says it's iOS 7.0 only (but comments talks about OSX)
		// yet both 7.0+ and 10.9 returns null
		[Mavericks][Since (7,0)]
		[Internal][Field ("kCFHTTPAuthenticationSchemeOAuth1", "CFNetwork")]
		NSString _AuthenticationSchemeOAuth1 { get; }
	}
}
