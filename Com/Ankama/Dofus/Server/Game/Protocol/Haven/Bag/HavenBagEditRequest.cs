using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x0200047D RID: 1149
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagEditRequest : IMessage<HavenBagEditRequest>, IMessage, IEquatable<HavenBagEditRequest>, IDeepCloneable<HavenBagEditRequest>, IBufferMessage
	{
		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06003701 RID: 14081 RVA: 0x001DEB68 File Offset: 0x001DCD68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HavenBagEditRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06003702 RID: 14082 RVA: 0x001DEB78 File Offset: 0x001DCD78
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

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06003703 RID: 14083 RVA: 0x001DEB88 File Offset: 0x001DCD88
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

		// Token: 0x06003704 RID: 14084 RVA: 0x001DEB98 File Offset: 0x001DCD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagEditRequest()
		{
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x001DEBA8 File Offset: 0x001DCDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagEditRequest(HavenBagEditRequest other)
		{
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x001DEBB8 File Offset: 0x001DCDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagEditRequest Clone()
		{
			return null;
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x001DEBC8 File Offset: 0x001DCDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x001DEBD8 File Offset: 0x001DCDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagEditRequest other)
		{
			return true;
		}

		// Token: 0x06003709 RID: 14089 RVA: 0x001DEBE8 File Offset: 0x001DCDE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x001DEBF8 File Offset: 0x001DCDF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x001DEC08 File Offset: 0x001DCE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x001DEC18 File Offset: 0x001DCE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x001DEC28 File Offset: 0x001DCE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x001DEC38 File Offset: 0x001DCE38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagEditRequest other)
		{
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x001DEC48 File Offset: 0x001DCE48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x001DEC58 File Offset: 0x001DCE58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x001DEC68 File Offset: 0x001DCE68
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagEditRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					HavenBagEditRequest._parser = new MessageParser<HavenBagEditRequest>(() => null);
					num2 = 2;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 != 0)
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
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x001DED34 File Offset: 0x001DCF34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kVhGIROwffSPGaBdLPgC()
		{
			return true;
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x001DED3C File Offset: 0x001DCF3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagEditRequest Dwgr0wOwnME5xgQ2FZyj()
		{
			return null;
		}

		// Token: 0x0400134E RID: 4942
		private static readonly MessageParser<HavenBagEditRequest> _parser;

		// Token: 0x0400134F RID: 4943
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001350 RID: 4944
		private static HavenBagEditRequest Ge7GEvOtzkcr6hn1tUsS;
	}
}
