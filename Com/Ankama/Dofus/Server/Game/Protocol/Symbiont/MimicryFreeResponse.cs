using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Symbiont
{
	// Token: 0x02000108 RID: 264
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MimicryFreeResponse : IMessage<MimicryFreeResponse>, IMessage, IEquatable<MimicryFreeResponse>, IDeepCloneable<MimicryFreeResponse>, IBufferMessage
	{
		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x00196858 File Offset: 0x00194A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MimicryFreeResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x00196868 File Offset: 0x00194A68
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

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x00196878 File Offset: 0x00194A78
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

		// Token: 0x06000C07 RID: 3079 RVA: 0x00196888 File Offset: 0x00194A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MimicryFreeResponse()
		{
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00196898 File Offset: 0x00194A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MimicryFreeResponse(MimicryFreeResponse other)
		{
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x001968A8 File Offset: 0x00194AA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MimicryFreeResponse Clone()
		{
			return null;
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x001968B8 File Offset: 0x00194AB8
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x001968CC File Offset: 0x00194ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MimicryResult Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (MimicryResult)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x001968DC File Offset: 0x00194ADC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x001968EC File Offset: 0x00194AEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MimicryFreeResponse other)
		{
			return true;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x001968FC File Offset: 0x00194AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x0019690C File Offset: 0x00194B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0019691C File Offset: 0x00194B1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0019692C File Offset: 0x00194B2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0019693C File Offset: 0x00194B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0019694C File Offset: 0x00194B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MimicryFreeResponse other)
		{
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0019695C File Offset: 0x00194B5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x0019696C File Offset: 0x00194B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0019697C File Offset: 0x00194B7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MimicryFreeResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					MimicryFreeResponse._parser = new MessageParser<MimicryFreeResponse>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x00196A60 File Offset: 0x00194C60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tBIuA2OlucL8tnVEb6tL()
		{
			return true;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00196A68 File Offset: 0x00194C68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MimicryFreeResponse cv8mHuOl8W9KWRZP9aGd()
		{
			return null;
		}

		// Token: 0x0400045E RID: 1118
		private static readonly MessageParser<MimicryFreeResponse> _parser;

		// Token: 0x0400045F RID: 1119
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000460 RID: 1120
		public const int ResultFieldNumber = 1;

		// Token: 0x04000461 RID: 1121
		private MimicryResult result_;

		// Token: 0x04000462 RID: 1122
		internal static MimicryFreeResponse Kdus7oOlMLUKqOVXZFwF;
	}
}
