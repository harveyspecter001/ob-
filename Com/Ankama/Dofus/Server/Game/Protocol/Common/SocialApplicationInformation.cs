using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A6D RID: 2669
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SocialApplicationInformation : IMessage<SocialApplicationInformation>, IMessage, IEquatable<SocialApplicationInformation>, IDeepCloneable<SocialApplicationInformation>, IBufferMessage
	{
		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x06007F4A RID: 32586 RVA: 0x0025EBF0 File Offset: 0x0025CDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SocialApplicationInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x06007F4B RID: 32587 RVA: 0x0025EC00 File Offset: 0x0025CE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x06007F4C RID: 32588 RVA: 0x0025EC10 File Offset: 0x0025CE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06007F4D RID: 32589 RVA: 0x0025EC20 File Offset: 0x0025CE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SocialApplicationInformation()
		{
		}

		// Token: 0x06007F4E RID: 32590 RVA: 0x0025EC30 File Offset: 0x0025CE30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SocialApplicationInformation(SocialApplicationInformation other)
		{
		}

		// Token: 0x06007F4F RID: 32591 RVA: 0x0025EC40 File Offset: 0x0025CE40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SocialApplicationInformation Clone()
		{
			return null;
		}

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x06007F50 RID: 32592 RVA: 0x0025EC50 File Offset: 0x0025CE50
		// (set) Token: 0x06007F51 RID: 32593 RVA: 0x0025EC60 File Offset: 0x0025CE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterInformation PlayerInformation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x06007F52 RID: 32594 RVA: 0x0025EC70 File Offset: 0x0025CE70
		// (set) Token: 0x06007F53 RID: 32595 RVA: 0x0025EC80 File Offset: 0x0025CE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ApplyText
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x06007F54 RID: 32596 RVA: 0x0025EC90 File Offset: 0x0025CE90
		// (set) Token: 0x06007F55 RID: 32597 RVA: 0x0025ECA0 File Offset: 0x0025CEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CreationDate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06007F56 RID: 32598 RVA: 0x0025ECB0 File Offset: 0x0025CEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007F57 RID: 32599 RVA: 0x0025ECC0 File Offset: 0x0025CEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SocialApplicationInformation other)
		{
			return true;
		}

		// Token: 0x06007F58 RID: 32600 RVA: 0x0025ECD0 File Offset: 0x0025CED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007F59 RID: 32601 RVA: 0x0025ECE0 File Offset: 0x0025CEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007F5A RID: 32602 RVA: 0x0025ECF0 File Offset: 0x0025CEF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007F5B RID: 32603 RVA: 0x0025ED00 File Offset: 0x0025CF00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007F5C RID: 32604 RVA: 0x0025ED10 File Offset: 0x0025CF10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007F5D RID: 32605 RVA: 0x0025ED20 File Offset: 0x0025CF20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SocialApplicationInformation other)
		{
		}

		// Token: 0x06007F5E RID: 32606 RVA: 0x0025ED30 File Offset: 0x0025CF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007F5F RID: 32607 RVA: 0x0025ED40 File Offset: 0x0025CF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007F60 RID: 32608 RVA: 0x0025ED50 File Offset: 0x0025CF50
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SocialApplicationInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				SocialApplicationInformation._parser = new MessageParser<SocialApplicationInformation>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x06007F61 RID: 32609 RVA: 0x0025EE34 File Offset: 0x0025D034
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nWRpBqJGZqwQTD2U6trF()
		{
			return true;
		}

		// Token: 0x06007F62 RID: 32610 RVA: 0x0025EE3C File Offset: 0x0025D03C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SocialApplicationInformation IPMjZ0JGqmJjjQPAMGRc()
		{
			return null;
		}

		// Token: 0x04002E0F RID: 11791
		private static readonly MessageParser<SocialApplicationInformation> _parser;

		// Token: 0x04002E10 RID: 11792
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E11 RID: 11793
		public const int PlayerInformationFieldNumber = 1;

		// Token: 0x04002E12 RID: 11794
		private CharacterInformation playerInformation_;

		// Token: 0x04002E13 RID: 11795
		public const int ApplyTextFieldNumber = 2;

		// Token: 0x04002E14 RID: 11796
		private string applyText_;

		// Token: 0x04002E15 RID: 11797
		public const int CreationDateFieldNumber = 3;

		// Token: 0x04002E16 RID: 11798
		private long creationDate_;

		// Token: 0x04002E17 RID: 11799
		internal static SocialApplicationInformation KjyVTmJG8HySIZSDkYkb;
	}
}
