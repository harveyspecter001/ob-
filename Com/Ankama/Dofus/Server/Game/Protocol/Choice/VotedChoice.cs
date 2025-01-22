using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice
{
	// Token: 0x020008BB RID: 2235
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class VotedChoice : IMessage<VotedChoice>, IMessage, IEquatable<VotedChoice>, IDeepCloneable<VotedChoice>, IBufferMessage
	{
		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x06006C8C RID: 27788 RVA: 0x00233380 File Offset: 0x00231580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<VotedChoice> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x06006C8D RID: 27789 RVA: 0x00233390 File Offset: 0x00231590
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

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x06006C8E RID: 27790 RVA: 0x002333A0 File Offset: 0x002315A0
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

		// Token: 0x06006C8F RID: 27791 RVA: 0x002333B0 File Offset: 0x002315B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public VotedChoice()
		{
		}

		// Token: 0x06006C90 RID: 27792 RVA: 0x002333C0 File Offset: 0x002315C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public VotedChoice(VotedChoice other)
		{
		}

		// Token: 0x06006C91 RID: 27793 RVA: 0x002333D0 File Offset: 0x002315D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public VotedChoice Clone()
		{
			return null;
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x06006C92 RID: 27794 RVA: 0x002333E0 File Offset: 0x002315E0
		// (set) Token: 0x06006C93 RID: 27795 RVA: 0x002333F0 File Offset: 0x002315F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x06006C94 RID: 27796 RVA: 0x00233400 File Offset: 0x00231600
		// (set) Token: 0x06006C95 RID: 27797 RVA: 0x00233410 File Offset: 0x00231610
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Position
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

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06006C96 RID: 27798 RVA: 0x00233420 File Offset: 0x00231620
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<long> Players
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006C97 RID: 27799 RVA: 0x00233430 File Offset: 0x00231630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006C98 RID: 27800 RVA: 0x00233440 File Offset: 0x00231640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(VotedChoice other)
		{
			return true;
		}

		// Token: 0x06006C99 RID: 27801 RVA: 0x00233450 File Offset: 0x00231650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006C9A RID: 27802 RVA: 0x00233460 File Offset: 0x00231660
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006C9B RID: 27803 RVA: 0x00233470 File Offset: 0x00231670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006C9C RID: 27804 RVA: 0x00233480 File Offset: 0x00231680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006C9D RID: 27805 RVA: 0x00233490 File Offset: 0x00231690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006C9E RID: 27806 RVA: 0x002334A0 File Offset: 0x002316A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(VotedChoice other)
		{
		}

		// Token: 0x06006C9F RID: 27807 RVA: 0x002334B0 File Offset: 0x002316B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006CA0 RID: 27808 RVA: 0x002334C0 File Offset: 0x002316C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006CA1 RID: 27809 RVA: 0x002334D0 File Offset: 0x002316D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static VotedChoice()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 5;
						continue;
					case 3:
						return;
					case 4:
						goto IL_9F;
					case 5:
						VotedChoice._parser = new MessageParser<VotedChoice>(() => null);
						num2 = 4;
						continue;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
					{
						num2 = 2;
					}
				}
				IL_9F:
				VotedChoice._repeated_players_codec = VvZHhZNDXJ0wdfV8NAG.XVInXhlssT(26U, VvZHhZNDXJ0wdfV8NAG.zpwNtgb0bl);
				num = 3;
			}
		}

		// Token: 0x06006CA2 RID: 27810 RVA: 0x002335C0 File Offset: 0x002317C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yXlndcJAJrsMuLJykulB()
		{
			return true;
		}

		// Token: 0x06006CA3 RID: 27811 RVA: 0x002335C8 File Offset: 0x002317C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static VotedChoice fhradNJAGOSXjQvBjXCb()
		{
			return null;
		}

		// Token: 0x040025D9 RID: 9689
		private static readonly MessageParser<VotedChoice> _parser;

		// Token: 0x040025DA RID: 9690
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025DB RID: 9691
		public const int IdFieldNumber = 1;

		// Token: 0x040025DC RID: 9692
		private int id_;

		// Token: 0x040025DD RID: 9693
		public const int PositionFieldNumber = 2;

		// Token: 0x040025DE RID: 9694
		private int position_;

		// Token: 0x040025DF RID: 9695
		public const int PlayersFieldNumber = 3;

		// Token: 0x040025E0 RID: 9696
		private static readonly FieldCodec<long> _repeated_players_codec;

		// Token: 0x040025E1 RID: 9697
		private readonly RepeatedField<long> players_;

		// Token: 0x040025E2 RID: 9698
		private static VotedChoice QBo78hJAOmqt4OPajVkb;
	}
}
