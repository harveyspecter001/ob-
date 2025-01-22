using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Element
{
	// Token: 0x020007D8 RID: 2008
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LockableStateUpdateHouseDoorEvent : IMessage<LockableStateUpdateHouseDoorEvent>, IMessage, IEquatable<LockableStateUpdateHouseDoorEvent>, IDeepCloneable<LockableStateUpdateHouseDoorEvent>, IBufferMessage
	{
		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x0600622E RID: 25134 RVA: 0x00222584 File Offset: 0x00220784
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<LockableStateUpdateHouseDoorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x0600622F RID: 25135 RVA: 0x00222594 File Offset: 0x00220794
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

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x06006230 RID: 25136 RVA: 0x002225A4 File Offset: 0x002207A4
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

		// Token: 0x06006231 RID: 25137 RVA: 0x002225B4 File Offset: 0x002207B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LockableStateUpdateHouseDoorEvent()
		{
		}

		// Token: 0x06006232 RID: 25138 RVA: 0x002225C4 File Offset: 0x002207C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LockableStateUpdateHouseDoorEvent(LockableStateUpdateHouseDoorEvent other)
		{
		}

		// Token: 0x06006233 RID: 25139 RVA: 0x002225D4 File Offset: 0x002207D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LockableStateUpdateHouseDoorEvent Clone()
		{
			return null;
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x06006234 RID: 25140 RVA: 0x002225E4 File Offset: 0x002207E4
		// (set) Token: 0x06006235 RID: 25141 RVA: 0x002225F4 File Offset: 0x002207F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HouseId
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

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x06006236 RID: 25142 RVA: 0x00222604 File Offset: 0x00220804
		// (set) Token: 0x06006237 RID: 25143 RVA: 0x00222614 File Offset: 0x00220814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HouseInstanceId
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

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06006238 RID: 25144 RVA: 0x00222624 File Offset: 0x00220824
		// (set) Token: 0x06006239 RID: 25145 RVA: 0x00222634 File Offset: 0x00220834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool SecondHand
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

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x0600623A RID: 25146 RVA: 0x00222644 File Offset: 0x00220844
		// (set) Token: 0x0600623B RID: 25147 RVA: 0x00222654 File Offset: 0x00220854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Locked
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

		// Token: 0x0600623C RID: 25148 RVA: 0x00222664 File Offset: 0x00220864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600623D RID: 25149 RVA: 0x00222674 File Offset: 0x00220874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(LockableStateUpdateHouseDoorEvent other)
		{
			return true;
		}

		// Token: 0x0600623E RID: 25150 RVA: 0x00222684 File Offset: 0x00220884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600623F RID: 25151 RVA: 0x00222694 File Offset: 0x00220894
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006240 RID: 25152 RVA: 0x002226A4 File Offset: 0x002208A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006241 RID: 25153 RVA: 0x002226B4 File Offset: 0x002208B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006242 RID: 25154 RVA: 0x002226C4 File Offset: 0x002208C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006243 RID: 25155 RVA: 0x002226D4 File Offset: 0x002208D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(LockableStateUpdateHouseDoorEvent other)
		{
		}

		// Token: 0x06006244 RID: 25156 RVA: 0x002226E4 File Offset: 0x002208E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006245 RID: 25157 RVA: 0x002226F4 File Offset: 0x002208F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006246 RID: 25158 RVA: 0x00222704 File Offset: 0x00220904
		[MethodImpl(MethodImplOptions.NoInlining)]
		static LockableStateUpdateHouseDoorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					LockableStateUpdateHouseDoorEvent._parser = new MessageParser<LockableStateUpdateHouseDoorEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
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
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06006247 RID: 25159 RVA: 0x002227FC File Offset: 0x002209FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FumfN4OFa2ekXuZipBpp()
		{
			return true;
		}

		// Token: 0x06006248 RID: 25160 RVA: 0x00222804 File Offset: 0x00220A04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LockableStateUpdateHouseDoorEvent gAfla3OF5XDKBrQlbRAm()
		{
			return null;
		}

		// Token: 0x04002286 RID: 8838
		private static readonly MessageParser<LockableStateUpdateHouseDoorEvent> _parser;

		// Token: 0x04002287 RID: 8839
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002288 RID: 8840
		public const int HouseIdFieldNumber = 1;

		// Token: 0x04002289 RID: 8841
		private int houseId_;

		// Token: 0x0400228A RID: 8842
		public const int HouseInstanceIdFieldNumber = 2;

		// Token: 0x0400228B RID: 8843
		private int houseInstanceId_;

		// Token: 0x0400228C RID: 8844
		public const int SecondHandFieldNumber = 3;

		// Token: 0x0400228D RID: 8845
		private bool secondHand_;

		// Token: 0x0400228E RID: 8846
		public const int LockedFieldNumber = 4;

		// Token: 0x0400228F RID: 8847
		private bool locked_;

		// Token: 0x04002290 RID: 8848
		internal static LockableStateUpdateHouseDoorEvent sL7CtMOF1iyoCSUvP3J2;
	}
}
