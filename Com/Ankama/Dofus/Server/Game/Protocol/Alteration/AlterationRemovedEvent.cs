using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alteration
{
	// Token: 0x02000CEF RID: 3311
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlterationRemovedEvent : IMessage<AlterationRemovedEvent>, IMessage, IEquatable<AlterationRemovedEvent>, IDeepCloneable<AlterationRemovedEvent>, IBufferMessage
	{
		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x06009F5A RID: 40794 RVA: 0x00285690 File Offset: 0x00283890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlterationRemovedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x06009F5B RID: 40795 RVA: 0x002856A0 File Offset: 0x002838A0
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

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x06009F5C RID: 40796 RVA: 0x002856B0 File Offset: 0x002838B0
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

		// Token: 0x06009F5D RID: 40797 RVA: 0x002856C0 File Offset: 0x002838C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlterationRemovedEvent()
		{
		}

		// Token: 0x06009F5E RID: 40798 RVA: 0x002856D0 File Offset: 0x002838D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlterationRemovedEvent(AlterationRemovedEvent other)
		{
		}

		// Token: 0x06009F5F RID: 40799 RVA: 0x002856E0 File Offset: 0x002838E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AlterationRemovedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x06009F60 RID: 40800 RVA: 0x002856F0 File Offset: 0x002838F0
		// (set) Token: 0x06009F61 RID: 40801 RVA: 0x00285700 File Offset: 0x00283900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Alteration Alteration
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

		// Token: 0x06009F62 RID: 40802 RVA: 0x00285710 File Offset: 0x00283910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009F63 RID: 40803 RVA: 0x00285720 File Offset: 0x00283920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AlterationRemovedEvent other)
		{
			return true;
		}

		// Token: 0x06009F64 RID: 40804 RVA: 0x00285730 File Offset: 0x00283930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009F65 RID: 40805 RVA: 0x00285740 File Offset: 0x00283940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009F66 RID: 40806 RVA: 0x00285750 File Offset: 0x00283950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009F67 RID: 40807 RVA: 0x00285760 File Offset: 0x00283960
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009F68 RID: 40808 RVA: 0x00285770 File Offset: 0x00283970
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009F69 RID: 40809 RVA: 0x00285780 File Offset: 0x00283980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AlterationRemovedEvent other)
		{
		}

		// Token: 0x06009F6A RID: 40810 RVA: 0x00285790 File Offset: 0x00283990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009F6B RID: 40811 RVA: 0x002857A0 File Offset: 0x002839A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009F6C RID: 40812 RVA: 0x002857B0 File Offset: 0x002839B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AlterationRemovedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AlterationRemovedEvent._parser = new MessageParser<AlterationRemovedEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06009F6D RID: 40813 RVA: 0x002858A8 File Offset: 0x00283AA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BrkO3qJjUYib5vCk1hnp()
		{
			return true;
		}

		// Token: 0x06009F6E RID: 40814 RVA: 0x002858B0 File Offset: 0x00283AB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AlterationRemovedEvent r9KWv0JjvJmJNaZwoMX0()
		{
			return null;
		}

		// Token: 0x04003B03 RID: 15107
		private static readonly MessageParser<AlterationRemovedEvent> _parser;

		// Token: 0x04003B04 RID: 15108
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B05 RID: 15109
		public const int AlterationFieldNumber = 1;

		// Token: 0x04003B06 RID: 15110
		private Alteration alteration_;

		// Token: 0x04003B07 RID: 15111
		private static AlterationRemovedEvent kZWHe4JjcKDmfgK6DsLo;
	}
}
