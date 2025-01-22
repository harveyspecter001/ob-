using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000725 RID: 1829
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeKamaModifiedEvent : IMessage<ExchangeKamaModifiedEvent>, IMessage, IEquatable<ExchangeKamaModifiedEvent>, IDeepCloneable<ExchangeKamaModifiedEvent>, IBufferMessage
	{
		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x06005992 RID: 22930 RVA: 0x00217970 File Offset: 0x00215B70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeKamaModifiedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x06005993 RID: 22931 RVA: 0x00217980 File Offset: 0x00215B80
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

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06005994 RID: 22932 RVA: 0x00217990 File Offset: 0x00215B90
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

		// Token: 0x06005995 RID: 22933 RVA: 0x002179A0 File Offset: 0x00215BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeKamaModifiedEvent()
		{
		}

		// Token: 0x06005996 RID: 22934 RVA: 0x002179B0 File Offset: 0x00215BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeKamaModifiedEvent(ExchangeKamaModifiedEvent other)
		{
		}

		// Token: 0x06005997 RID: 22935 RVA: 0x002179C0 File Offset: 0x00215BC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeKamaModifiedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06005998 RID: 22936 RVA: 0x002179D0 File Offset: 0x00215BD0
		// (set) Token: 0x06005999 RID: 22937 RVA: 0x002179E0 File Offset: 0x00215BE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Remote
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x0600599A RID: 22938 RVA: 0x002179F0 File Offset: 0x00215BF0
		// (set) Token: 0x0600599B RID: 22939 RVA: 0x00217A00 File Offset: 0x00215C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Quantity
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

		// Token: 0x0600599C RID: 22940 RVA: 0x00217A10 File Offset: 0x00215C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600599D RID: 22941 RVA: 0x00217A20 File Offset: 0x00215C20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeKamaModifiedEvent other)
		{
			return true;
		}

		// Token: 0x0600599E RID: 22942 RVA: 0x00217A30 File Offset: 0x00215C30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600599F RID: 22943 RVA: 0x00217A40 File Offset: 0x00215C40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060059A0 RID: 22944 RVA: 0x00217A50 File Offset: 0x00215C50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060059A1 RID: 22945 RVA: 0x00217A60 File Offset: 0x00215C60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060059A2 RID: 22946 RVA: 0x00217A70 File Offset: 0x00215C70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060059A3 RID: 22947 RVA: 0x00217A80 File Offset: 0x00215C80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeKamaModifiedEvent other)
		{
		}

		// Token: 0x060059A4 RID: 22948 RVA: 0x00217A90 File Offset: 0x00215C90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060059A5 RID: 22949 RVA: 0x00217AA0 File Offset: 0x00215CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060059A6 RID: 22950 RVA: 0x00217AB0 File Offset: 0x00215CB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeKamaModifiedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ExchangeKamaModifiedEvent._parser = new MessageParser<ExchangeKamaModifiedEvent>(() => null);
					num2 = 2;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
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
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060059A7 RID: 22951 RVA: 0x00217B7C File Offset: 0x00215D7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VSLrBeOuFo1hsg2NvvmV()
		{
			return true;
		}

		// Token: 0x060059A8 RID: 22952 RVA: 0x00217B84 File Offset: 0x00215D84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeKamaModifiedEvent cQhggpOuz8cYThlCPZki()
		{
			return null;
		}

		// Token: 0x04001F5E RID: 8030
		private static readonly MessageParser<ExchangeKamaModifiedEvent> _parser;

		// Token: 0x04001F5F RID: 8031
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F60 RID: 8032
		public const int RemoteFieldNumber = 1;

		// Token: 0x04001F61 RID: 8033
		private bool remote_;

		// Token: 0x04001F62 RID: 8034
		public const int QuantityFieldNumber = 2;

		// Token: 0x04001F63 RID: 8035
		private long quantity_;

		// Token: 0x04001F64 RID: 8036
		internal static ExchangeKamaModifiedEvent vgdfQ9OuqbqEJdJD4SHA;
	}
}
