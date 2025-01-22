using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak
{
	// Token: 0x02000BF8 RID: 3064
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BakShopTokenRequest : IMessage<BakShopTokenRequest>, IMessage, IEquatable<BakShopTokenRequest>, IDeepCloneable<BakShopTokenRequest>, IBufferMessage
	{
		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x06009364 RID: 37732 RVA: 0x00272E90 File Offset: 0x00271090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BakShopTokenRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x06009365 RID: 37733 RVA: 0x00272EA0 File Offset: 0x002710A0
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

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x06009366 RID: 37734 RVA: 0x00272EB0 File Offset: 0x002710B0
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

		// Token: 0x06009367 RID: 37735 RVA: 0x00272EC0 File Offset: 0x002710C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakShopTokenRequest()
		{
		}

		// Token: 0x06009368 RID: 37736 RVA: 0x00272ED0 File Offset: 0x002710D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakShopTokenRequest(BakShopTokenRequest other)
		{
		}

		// Token: 0x06009369 RID: 37737 RVA: 0x00272EE0 File Offset: 0x002710E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakShopTokenRequest Clone()
		{
			return null;
		}

		// Token: 0x0600936A RID: 37738 RVA: 0x00272EF0 File Offset: 0x002710F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600936B RID: 37739 RVA: 0x00272F00 File Offset: 0x00271100
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BakShopTokenRequest other)
		{
			return true;
		}

		// Token: 0x0600936C RID: 37740 RVA: 0x00272F10 File Offset: 0x00271110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600936D RID: 37741 RVA: 0x00272F20 File Offset: 0x00271120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600936E RID: 37742 RVA: 0x00272F30 File Offset: 0x00271130
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600936F RID: 37743 RVA: 0x00272F40 File Offset: 0x00271140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009370 RID: 37744 RVA: 0x00272F50 File Offset: 0x00271150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009371 RID: 37745 RVA: 0x00272F60 File Offset: 0x00271160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BakShopTokenRequest other)
		{
		}

		// Token: 0x06009372 RID: 37746 RVA: 0x00272F70 File Offset: 0x00271170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009373 RID: 37747 RVA: 0x00272F80 File Offset: 0x00271180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009374 RID: 37748 RVA: 0x00272F90 File Offset: 0x00271190
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BakShopTokenRequest()
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
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					BakShopTokenRequest._parser = new MessageParser<BakShopTokenRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06009375 RID: 37749 RVA: 0x0027305C File Offset: 0x0027125C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gnDcopJE7UG0IpVGHh6C()
		{
			return true;
		}

		// Token: 0x06009376 RID: 37750 RVA: 0x00273064 File Offset: 0x00271264
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BakShopTokenRequest WOkZPtJETopwMxiJf1gJ()
		{
			return null;
		}

		// Token: 0x040036E1 RID: 14049
		private static readonly MessageParser<BakShopTokenRequest> _parser;

		// Token: 0x040036E2 RID: 14050
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036E3 RID: 14051
		private static BakShopTokenRequest hi2tBXJEQfs87jBFCg9v;
	}
}
