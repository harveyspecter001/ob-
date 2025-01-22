using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haapi
{
	// Token: 0x020004B0 RID: 1200
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HaapiTokenEvent : IMessage<HaapiTokenEvent>, IMessage, IEquatable<HaapiTokenEvent>, IDeepCloneable<HaapiTokenEvent>, IBufferMessage
	{
		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x0600395B RID: 14683 RVA: 0x001E1BE8 File Offset: 0x001DFDE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HaapiTokenEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x0600395C RID: 14684 RVA: 0x001E1BF8 File Offset: 0x001DFDF8
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

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x0600395D RID: 14685 RVA: 0x001E1C08 File Offset: 0x001DFE08
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

		// Token: 0x0600395E RID: 14686 RVA: 0x001E1C18 File Offset: 0x001DFE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HaapiTokenEvent()
		{
		}

		// Token: 0x0600395F RID: 14687 RVA: 0x001E1C28 File Offset: 0x001DFE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HaapiTokenEvent(HaapiTokenEvent other)
		{
		}

		// Token: 0x06003960 RID: 14688 RVA: 0x001E1C38 File Offset: 0x001DFE38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HaapiTokenEvent Clone()
		{
			return null;
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06003961 RID: 14689 RVA: 0x001E1C48 File Offset: 0x001DFE48
		// (set) Token: 0x06003962 RID: 14690 RVA: 0x001E1C58 File Offset: 0x001DFE58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Token
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

		// Token: 0x06003963 RID: 14691 RVA: 0x001E1C68 File Offset: 0x001DFE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x001E1C78 File Offset: 0x001DFE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HaapiTokenEvent other)
		{
			return true;
		}

		// Token: 0x06003965 RID: 14693 RVA: 0x001E1C88 File Offset: 0x001DFE88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x001E1C98 File Offset: 0x001DFE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x001E1CA8 File Offset: 0x001DFEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003968 RID: 14696 RVA: 0x001E1CB8 File Offset: 0x001DFEB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003969 RID: 14697 RVA: 0x001E1CC8 File Offset: 0x001DFEC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600396A RID: 14698 RVA: 0x001E1CD8 File Offset: 0x001DFED8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HaapiTokenEvent other)
		{
		}

		// Token: 0x0600396B RID: 14699 RVA: 0x001E1CE8 File Offset: 0x001DFEE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x001E1CF8 File Offset: 0x001DFEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600396D RID: 14701 RVA: 0x001E1D08 File Offset: 0x001DFF08
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HaapiTokenEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				HaapiTokenEvent._parser = new MessageParser<HaapiTokenEvent>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x0600396E RID: 14702 RVA: 0x001E1DEC File Offset: 0x001DFFEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AUyHd6OQRJ1gYZPPomDD()
		{
			return true;
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x001E1DF4 File Offset: 0x001DFFF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HaapiTokenEvent TlvQVXOQOnXBgQFpeiql()
		{
			return null;
		}

		// Token: 0x040013FE RID: 5118
		private static readonly MessageParser<HaapiTokenEvent> _parser;

		// Token: 0x040013FF RID: 5119
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001400 RID: 5120
		public const int TokenFieldNumber = 1;

		// Token: 0x04001401 RID: 5121
		private string token_;

		// Token: 0x04001402 RID: 5122
		internal static HaapiTokenEvent OEr6L5OQ3SehOcySDW00;
	}
}
