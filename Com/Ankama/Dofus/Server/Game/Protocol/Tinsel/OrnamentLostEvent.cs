using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel
{
	// Token: 0x02000073 RID: 115
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OrnamentLostEvent : IMessage<OrnamentLostEvent>, IMessage, IEquatable<OrnamentLostEvent>, IDeepCloneable<OrnamentLostEvent>, IBufferMessage
	{
		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x001895A4 File Offset: 0x001877A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OrnamentLostEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x001895B4 File Offset: 0x001877B4
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

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x001895C4 File Offset: 0x001877C4
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

		// Token: 0x06000488 RID: 1160 RVA: 0x001895D4 File Offset: 0x001877D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OrnamentLostEvent()
		{
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x001895E4 File Offset: 0x001877E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OrnamentLostEvent(OrnamentLostEvent other)
		{
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x001895F4 File Offset: 0x001877F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OrnamentLostEvent Clone()
		{
			return null;
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00189604 File Offset: 0x00187804
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00189614 File Offset: 0x00187814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OrnamentId
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

		// Token: 0x0600048D RID: 1165 RVA: 0x00189624 File Offset: 0x00187824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00189634 File Offset: 0x00187834
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OrnamentLostEvent other)
		{
			return true;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00189644 File Offset: 0x00187844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00189654 File Offset: 0x00187854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00189664 File Offset: 0x00187864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00189674 File Offset: 0x00187874
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00189684 File Offset: 0x00187884
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00189694 File Offset: 0x00187894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OrnamentLostEvent other)
		{
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x001896A4 File Offset: 0x001878A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x001896B4 File Offset: 0x001878B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x001896C4 File Offset: 0x001878C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OrnamentLostEvent()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					OrnamentLostEvent._parser = new MessageParser<OrnamentLostEvent>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x001897BC File Offset: 0x001879BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FY6J4MOK44md2QGZxCIF()
		{
			return true;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x001897C4 File Offset: 0x001879C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OrnamentLostEvent GuIDs1OKjRTk12SNj1th()
		{
			return null;
		}

		// Token: 0x040001CC RID: 460
		private static readonly MessageParser<OrnamentLostEvent> _parser;

		// Token: 0x040001CD RID: 461
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001CE RID: 462
		public const int OrnamentIdFieldNumber = 1;

		// Token: 0x040001CF RID: 463
		private int ornamentId_;

		// Token: 0x040001D0 RID: 464
		private static OrnamentLostEvent YVMhVhOKxMWYwC9xFeOX;
	}
}
