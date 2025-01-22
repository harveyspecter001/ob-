using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002B4 RID: 692
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightAutoJoinActivationResponse : IMessage<FightAutoJoinActivationResponse>, IMessage, IEquatable<FightAutoJoinActivationResponse>, IDeepCloneable<FightAutoJoinActivationResponse>, IBufferMessage
	{
		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06002040 RID: 8256 RVA: 0x001B9C2C File Offset: 0x001B7E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightAutoJoinActivationResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x001B9C3C File Offset: 0x001B7E3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06002042 RID: 8258 RVA: 0x001B9C4C File Offset: 0x001B7E4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x001B9C5C File Offset: 0x001B7E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoJoinActivationResponse()
		{
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x001B9C6C File Offset: 0x001B7E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoJoinActivationResponse(FightAutoJoinActivationResponse other)
		{
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x001B9C7C File Offset: 0x001B7E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoJoinActivationResponse Clone()
		{
			return null;
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06002046 RID: 8262 RVA: 0x001B9C8C File Offset: 0x001B7E8C
		// (set) Token: 0x06002047 RID: 8263 RVA: 0x001B9CA0 File Offset: 0x001B7EA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightAutoJoinActivationResponse.Types.Result Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FightAutoJoinActivationResponse.Types.Result)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x001B9CB0 File Offset: 0x001B7EB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x001B9CC0 File Offset: 0x001B7EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightAutoJoinActivationResponse other)
		{
			return true;
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x001B9CD0 File Offset: 0x001B7ED0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x001B9CE0 File Offset: 0x001B7EE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x001B9CF0 File Offset: 0x001B7EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x001B9D00 File Offset: 0x001B7F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x001B9D10 File Offset: 0x001B7F10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x001B9D20 File Offset: 0x001B7F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightAutoJoinActivationResponse other)
		{
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x001B9D30 File Offset: 0x001B7F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x001B9D40 File Offset: 0x001B7F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x001B9D50 File Offset: 0x001B7F50
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightAutoJoinActivationResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					FightAutoJoinActivationResponse._parser = new MessageParser<FightAutoJoinActivationResponse>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x001B9E1C File Offset: 0x001B801C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PaHxpwO69dCSQCanN1U1()
		{
			return true;
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x001B9E24 File Offset: 0x001B8024
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightAutoJoinActivationResponse IvIAe2O620M4jHQGEqLD()
		{
			return null;
		}

		// Token: 0x04000B53 RID: 2899
		private static readonly MessageParser<FightAutoJoinActivationResponse> _parser;

		// Token: 0x04000B54 RID: 2900
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B55 RID: 2901
		public const int ResultFieldNumber = 1;

		// Token: 0x04000B56 RID: 2902
		private FightAutoJoinActivationResponse.Types.Result result_;

		// Token: 0x04000B57 RID: 2903
		internal static FightAutoJoinActivationResponse A669WOO6d8SWYIPFlMlx;

		// Token: 0x020002B5 RID: 693
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06002055 RID: 8277 RVA: 0x002B4764 File Offset: 0x002B2964
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020002B6 RID: 694
			public enum Result
			{
				// Token: 0x04000B59 RID: 2905
				[OriginalName("SUCCESS")]
				Success,
				// Token: 0x04000B5A RID: 2906
				[OriginalName("ERROR")]
				Error
			}
		}
	}
}
