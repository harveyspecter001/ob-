using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context
{
	// Token: 0x02000821 RID: 2081
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShowCellEvent : IMessage<ShowCellEvent>, IMessage, IEquatable<ShowCellEvent>, IDeepCloneable<ShowCellEvent>, IBufferMessage
	{
		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x06006541 RID: 25921 RVA: 0x00227B14 File Offset: 0x00225D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShowCellEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x06006542 RID: 25922 RVA: 0x00227B24 File Offset: 0x00225D24
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

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x06006543 RID: 25923 RVA: 0x00227B34 File Offset: 0x00225D34
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

		// Token: 0x06006544 RID: 25924 RVA: 0x00227B44 File Offset: 0x00225D44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShowCellEvent()
		{
		}

		// Token: 0x06006545 RID: 25925 RVA: 0x00227B54 File Offset: 0x00225D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShowCellEvent(ShowCellEvent other)
		{
		}

		// Token: 0x06006546 RID: 25926 RVA: 0x00227B64 File Offset: 0x00225D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShowCellEvent Clone()
		{
			return null;
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x06006547 RID: 25927 RVA: 0x00227B74 File Offset: 0x00225D74
		// (set) Token: 0x06006548 RID: 25928 RVA: 0x00227B84 File Offset: 0x00225D84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long SourceId
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

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06006549 RID: 25929 RVA: 0x00227B94 File Offset: 0x00225D94
		// (set) Token: 0x0600654A RID: 25930 RVA: 0x00227BA4 File Offset: 0x00225DA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CellId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600654B RID: 25931 RVA: 0x00227BB4 File Offset: 0x00225DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600654C RID: 25932 RVA: 0x00227BC4 File Offset: 0x00225DC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ShowCellEvent other)
		{
			return true;
		}

		// Token: 0x0600654D RID: 25933 RVA: 0x00227BD4 File Offset: 0x00225DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600654E RID: 25934 RVA: 0x00227BE4 File Offset: 0x00225DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600654F RID: 25935 RVA: 0x00227BF4 File Offset: 0x00225DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006550 RID: 25936 RVA: 0x00227C04 File Offset: 0x00225E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006551 RID: 25937 RVA: 0x00227C14 File Offset: 0x00225E14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006552 RID: 25938 RVA: 0x00227C24 File Offset: 0x00225E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ShowCellEvent other)
		{
		}

		// Token: 0x06006553 RID: 25939 RVA: 0x00227C34 File Offset: 0x00225E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006554 RID: 25940 RVA: 0x00227C44 File Offset: 0x00225E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006555 RID: 25941 RVA: 0x00227C54 File Offset: 0x00225E54
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ShowCellEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 4;
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				IL_73:
				ShowCellEvent._parser = new MessageParser<ShowCellEvent>(() => null);
				num = 3;
				continue;
				goto IL_73;
			}
		}

		// Token: 0x06006556 RID: 25942 RVA: 0x00227D24 File Offset: 0x00225F24
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool m4w0FSJf3X0M0NLASPHG()
		{
			return true;
		}

		// Token: 0x06006557 RID: 25943 RVA: 0x00227D2C File Offset: 0x00225F2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ShowCellEvent JHB9UDJfRSbgj4UFUdWW()
		{
			return null;
		}

		// Token: 0x0400238C RID: 9100
		private static readonly MessageParser<ShowCellEvent> _parser;

		// Token: 0x0400238D RID: 9101
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400238E RID: 9102
		public const int SourceIdFieldNumber = 1;

		// Token: 0x0400238F RID: 9103
		private long sourceId_;

		// Token: 0x04002390 RID: 9104
		public const int CellIdFieldNumber = 2;

		// Token: 0x04002391 RID: 9105
		private int cellId_;

		// Token: 0x04002392 RID: 9106
		internal static ShowCellEvent FpuvdIJfeDVIsy5BTt1H;
	}
}
