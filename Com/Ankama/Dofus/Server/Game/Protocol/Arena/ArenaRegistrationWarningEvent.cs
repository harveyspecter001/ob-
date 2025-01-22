using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C28 RID: 3112
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ArenaRegistrationWarningEvent : IMessage<ArenaRegistrationWarningEvent>, IMessage, IEquatable<ArenaRegistrationWarningEvent>, IDeepCloneable<ArenaRegistrationWarningEvent>, IBufferMessage
	{
		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x06009593 RID: 38291 RVA: 0x002774B8 File Offset: 0x002756B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ArenaRegistrationWarningEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x06009594 RID: 38292 RVA: 0x002774C8 File Offset: 0x002756C8
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

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x06009595 RID: 38293 RVA: 0x002774D8 File Offset: 0x002756D8
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

		// Token: 0x06009596 RID: 38294 RVA: 0x002774E8 File Offset: 0x002756E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaRegistrationWarningEvent()
		{
		}

		// Token: 0x06009597 RID: 38295 RVA: 0x002774F8 File Offset: 0x002756F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaRegistrationWarningEvent(ArenaRegistrationWarningEvent other)
		{
		}

		// Token: 0x06009598 RID: 38296 RVA: 0x00277508 File Offset: 0x00275708
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaRegistrationWarningEvent Clone()
		{
			return null;
		}

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x06009599 RID: 38297 RVA: 0x00277518 File Offset: 0x00275718
		// (set) Token: 0x0600959A RID: 38298 RVA: 0x0027752C File Offset: 0x0027572C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArenaType BattleMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ArenaType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600959B RID: 38299 RVA: 0x0027753C File Offset: 0x0027573C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600959C RID: 38300 RVA: 0x0027754C File Offset: 0x0027574C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ArenaRegistrationWarningEvent other)
		{
			return true;
		}

		// Token: 0x0600959D RID: 38301 RVA: 0x0027755C File Offset: 0x0027575C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600959E RID: 38302 RVA: 0x0027756C File Offset: 0x0027576C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600959F RID: 38303 RVA: 0x0027757C File Offset: 0x0027577C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060095A0 RID: 38304 RVA: 0x0027758C File Offset: 0x0027578C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060095A1 RID: 38305 RVA: 0x0027759C File Offset: 0x0027579C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060095A2 RID: 38306 RVA: 0x002775AC File Offset: 0x002757AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ArenaRegistrationWarningEvent other)
		{
		}

		// Token: 0x060095A3 RID: 38307 RVA: 0x002775BC File Offset: 0x002757BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060095A4 RID: 38308 RVA: 0x002775CC File Offset: 0x002757CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060095A5 RID: 38309 RVA: 0x002775DC File Offset: 0x002757DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ArenaRegistrationWarningEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				ArenaRegistrationWarningEvent._parser = new MessageParser<ArenaRegistrationWarningEvent>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x060095A6 RID: 38310 RVA: 0x002776A8 File Offset: 0x002758A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Fk40qoJXCMHADhnaJajo()
		{
			return true;
		}

		// Token: 0x060095A7 RID: 38311 RVA: 0x002776B0 File Offset: 0x002758B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ArenaRegistrationWarningEvent YW7hNoJXDVs5o04Jm2hb()
		{
			return null;
		}

		// Token: 0x040037BA RID: 14266
		private static readonly MessageParser<ArenaRegistrationWarningEvent> _parser;

		// Token: 0x040037BB RID: 14267
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037BC RID: 14268
		public const int BattleModeFieldNumber = 1;

		// Token: 0x040037BD RID: 14269
		private ArenaType battleMode_;

		// Token: 0x040037BE RID: 14270
		private static ArenaRegistrationWarningEvent YLDUf9JX04UuOo0q7aWl;
	}
}
