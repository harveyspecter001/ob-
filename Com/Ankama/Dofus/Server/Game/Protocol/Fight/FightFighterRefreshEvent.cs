using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x0200068A RID: 1674
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightFighterRefreshEvent : IMessage<FightFighterRefreshEvent>, IMessage, IEquatable<FightFighterRefreshEvent>, IDeepCloneable<FightFighterRefreshEvent>, IBufferMessage
	{
		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x060051A9 RID: 20905 RVA: 0x00206408 File Offset: 0x00204608
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightFighterRefreshEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x060051AA RID: 20906 RVA: 0x00206418 File Offset: 0x00204618
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

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x060051AB RID: 20907 RVA: 0x00206428 File Offset: 0x00204628
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

		// Token: 0x060051AC RID: 20908 RVA: 0x00206438 File Offset: 0x00204638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightFighterRefreshEvent()
		{
		}

		// Token: 0x060051AD RID: 20909 RVA: 0x00206448 File Offset: 0x00204648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightFighterRefreshEvent(FightFighterRefreshEvent other)
		{
		}

		// Token: 0x060051AE RID: 20910 RVA: 0x00206458 File Offset: 0x00204658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightFighterRefreshEvent Clone()
		{
			return null;
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x060051AF RID: 20911 RVA: 0x00206468 File Offset: 0x00204668
		// (set) Token: 0x060051B0 RID: 20912 RVA: 0x00206478 File Offset: 0x00204678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorPositionInformation Information
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

		// Token: 0x060051B1 RID: 20913 RVA: 0x00206488 File Offset: 0x00204688
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060051B2 RID: 20914 RVA: 0x00206498 File Offset: 0x00204698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightFighterRefreshEvent other)
		{
			return true;
		}

		// Token: 0x060051B3 RID: 20915 RVA: 0x002064A8 File Offset: 0x002046A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060051B4 RID: 20916 RVA: 0x002064B8 File Offset: 0x002046B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060051B5 RID: 20917 RVA: 0x002064C8 File Offset: 0x002046C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060051B6 RID: 20918 RVA: 0x002064D8 File Offset: 0x002046D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060051B7 RID: 20919 RVA: 0x002064E8 File Offset: 0x002046E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060051B8 RID: 20920 RVA: 0x002064F8 File Offset: 0x002046F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightFighterRefreshEvent other)
		{
		}

		// Token: 0x060051B9 RID: 20921 RVA: 0x00206508 File Offset: 0x00204708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060051BA RID: 20922 RVA: 0x00206518 File Offset: 0x00204718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060051BB RID: 20923 RVA: 0x00206528 File Offset: 0x00204728
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightFighterRefreshEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					FightFighterRefreshEvent._parser = new MessageParser<FightFighterRefreshEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060051BC RID: 20924 RVA: 0x00206620 File Offset: 0x00204820
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bqZOUuOPjn2ZR7tHacYG()
		{
			return true;
		}

		// Token: 0x060051BD RID: 20925 RVA: 0x00206628 File Offset: 0x00204828
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightFighterRefreshEvent nTREZ8OPKiTbGOOeJdcB()
		{
			return null;
		}

		// Token: 0x04001CB1 RID: 7345
		private static readonly MessageParser<FightFighterRefreshEvent> _parser;

		// Token: 0x04001CB2 RID: 7346
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CB3 RID: 7347
		public const int InformationFieldNumber = 1;

		// Token: 0x04001CB4 RID: 7348
		private ActorPositionInformation information_;

		// Token: 0x04001CB5 RID: 7349
		internal static FightFighterRefreshEvent Lf21mbOP4sCpHHap2gYx;
	}
}
