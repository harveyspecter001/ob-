using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x0200047B RID: 1147
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagExitRequest : IMessage<HavenBagExitRequest>, IMessage, IEquatable<HavenBagExitRequest>, IDeepCloneable<HavenBagExitRequest>, IBufferMessage
	{
		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x060036E9 RID: 14057 RVA: 0x001DE98C File Offset: 0x001DCB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HavenBagExitRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x060036EA RID: 14058 RVA: 0x001DE99C File Offset: 0x001DCB9C
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

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x060036EB RID: 14059 RVA: 0x001DE9AC File Offset: 0x001DCBAC
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

		// Token: 0x060036EC RID: 14060 RVA: 0x001DE9BC File Offset: 0x001DCBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagExitRequest()
		{
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x001DE9CC File Offset: 0x001DCBCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagExitRequest(HavenBagExitRequest other)
		{
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x001DE9DC File Offset: 0x001DCBDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagExitRequest Clone()
		{
			return null;
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x001DE9EC File Offset: 0x001DCBEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x001DE9FC File Offset: 0x001DCBFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagExitRequest other)
		{
			return true;
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x001DEA0C File Offset: 0x001DCC0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x001DEA1C File Offset: 0x001DCC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x001DEA2C File Offset: 0x001DCC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x001DEA3C File Offset: 0x001DCC3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x001DEA4C File Offset: 0x001DCC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x001DEA5C File Offset: 0x001DCC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagExitRequest other)
		{
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x001DEA6C File Offset: 0x001DCC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x001DEA7C File Offset: 0x001DCC7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x001DEA8C File Offset: 0x001DCC8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagExitRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				case 3:
					HavenBagExitRequest._parser = new MessageParser<HavenBagExitRequest>(() => null);
					num2 = 4;
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x001DEB58 File Offset: 0x001DCD58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gCL8mSOtqTkUM8o8E8p8()
		{
			return true;
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x001DEB60 File Offset: 0x001DCD60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagExitRequest CbPjDNOtFvMsP6hhkxgN()
		{
			return null;
		}

		// Token: 0x04001349 RID: 4937
		private static readonly MessageParser<HavenBagExitRequest> _parser;

		// Token: 0x0400134A RID: 4938
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400134B RID: 4939
		internal static HavenBagExitRequest u4WRegOtZlZmp2oGW5Rn;
	}
}
