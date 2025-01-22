using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000AB8 RID: 2744
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTeamMemberTaxCollector : IMessage<FightTeamMemberTaxCollector>, IMessage, IEquatable<FightTeamMemberTaxCollector>, IDeepCloneable<FightTeamMemberTaxCollector>, IBufferMessage
	{
		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x06008330 RID: 33584 RVA: 0x0026313C File Offset: 0x0026133C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightTeamMemberTaxCollector> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x06008331 RID: 33585 RVA: 0x0026314C File Offset: 0x0026134C
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

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x06008332 RID: 33586 RVA: 0x0026315C File Offset: 0x0026135C
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

		// Token: 0x06008333 RID: 33587 RVA: 0x0026316C File Offset: 0x0026136C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamMemberTaxCollector()
		{
		}

		// Token: 0x06008334 RID: 33588 RVA: 0x0026317C File Offset: 0x0026137C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamMemberTaxCollector(FightTeamMemberTaxCollector other)
		{
		}

		// Token: 0x06008335 RID: 33589 RVA: 0x0026318C File Offset: 0x0026138C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamMemberTaxCollector Clone()
		{
			return null;
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x06008336 RID: 33590 RVA: 0x0026319C File Offset: 0x0026139C
		// (set) Token: 0x06008337 RID: 33591 RVA: 0x002631AC File Offset: 0x002613AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FirstNameId
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

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x06008338 RID: 33592 RVA: 0x002631BC File Offset: 0x002613BC
		// (set) Token: 0x06008339 RID: 33593 RVA: 0x002631CC File Offset: 0x002613CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastNameId
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

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x0600833A RID: 33594 RVA: 0x002631DC File Offset: 0x002613DC
		// (set) Token: 0x0600833B RID: 33595 RVA: 0x002631EC File Offset: 0x002613EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupId
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

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x0600833C RID: 33596 RVA: 0x002631FC File Offset: 0x002613FC
		// (set) Token: 0x0600833D RID: 33597 RVA: 0x0026320C File Offset: 0x0026140C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string TaxCollectorUid
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

		// Token: 0x0600833E RID: 33598 RVA: 0x0026321C File Offset: 0x0026141C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600833F RID: 33599 RVA: 0x0026322C File Offset: 0x0026142C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTeamMemberTaxCollector other)
		{
			return true;
		}

		// Token: 0x06008340 RID: 33600 RVA: 0x0026323C File Offset: 0x0026143C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008341 RID: 33601 RVA: 0x0026324C File Offset: 0x0026144C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008342 RID: 33602 RVA: 0x0026325C File Offset: 0x0026145C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008343 RID: 33603 RVA: 0x0026326C File Offset: 0x0026146C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008344 RID: 33604 RVA: 0x0026327C File Offset: 0x0026147C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008345 RID: 33605 RVA: 0x0026328C File Offset: 0x0026148C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTeamMemberTaxCollector other)
		{
		}

		// Token: 0x06008346 RID: 33606 RVA: 0x0026329C File Offset: 0x0026149C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008347 RID: 33607 RVA: 0x002632AC File Offset: 0x002614AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008348 RID: 33608 RVA: 0x002632BC File Offset: 0x002614BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTeamMemberTaxCollector()
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
						num2 = 3;
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_82;
					case 4:
						FightTeamMemberTaxCollector._parser = new MessageParser<FightTeamMemberTaxCollector>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_82:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
			}
		}

		// Token: 0x06008349 RID: 33609 RVA: 0x0026338C File Offset: 0x0026158C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IpvP9dJs2gP16FOAnoRh()
		{
			return true;
		}

		// Token: 0x0600834A RID: 33610 RVA: 0x00263394 File Offset: 0x00261594
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTeamMemberTaxCollector QunVt4JsEpotdn1I4n2j()
		{
			return null;
		}

		// Token: 0x04002FD2 RID: 12242
		private static readonly MessageParser<FightTeamMemberTaxCollector> _parser;

		// Token: 0x04002FD3 RID: 12243
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FD4 RID: 12244
		public const int FirstNameIdFieldNumber = 1;

		// Token: 0x04002FD5 RID: 12245
		private int firstNameId_;

		// Token: 0x04002FD6 RID: 12246
		public const int LastNameIdFieldNumber = 2;

		// Token: 0x04002FD7 RID: 12247
		private int lastNameId_;

		// Token: 0x04002FD8 RID: 12248
		public const int GroupIdFieldNumber = 3;

		// Token: 0x04002FD9 RID: 12249
		private int groupId_;

		// Token: 0x04002FDA RID: 12250
		public const int TaxCollectorUidFieldNumber = 4;

		// Token: 0x04002FDB RID: 12251
		private string taxCollectorUid_;

		// Token: 0x04002FDC RID: 12252
		private static FightTeamMemberTaxCollector bNCydRJs9fQmw5wmHOiA;
	}
}
