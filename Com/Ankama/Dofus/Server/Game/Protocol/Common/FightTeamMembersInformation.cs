using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000AAA RID: 2730
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTeamMembersInformation : IMessage<FightTeamMembersInformation>, IMessage, IEquatable<FightTeamMembersInformation>, IDeepCloneable<FightTeamMembersInformation>, IBufferMessage
	{
		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x0600827A RID: 33402 RVA: 0x00262538 File Offset: 0x00260738
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightTeamMembersInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x0600827B RID: 33403 RVA: 0x00262548 File Offset: 0x00260748
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

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x0600827C RID: 33404 RVA: 0x00262558 File Offset: 0x00260758
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

		// Token: 0x0600827D RID: 33405 RVA: 0x00262568 File Offset: 0x00260768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamMembersInformation()
		{
		}

		// Token: 0x0600827E RID: 33406 RVA: 0x00262578 File Offset: 0x00260778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamMembersInformation(FightTeamMembersInformation other)
		{
		}

		// Token: 0x0600827F RID: 33407 RVA: 0x00262588 File Offset: 0x00260788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamMembersInformation Clone()
		{
			return null;
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x06008280 RID: 33408 RVA: 0x00262598 File Offset: 0x00260798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightTeamMemberInformation> TeamMembers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x06008281 RID: 33409 RVA: 0x002625A8 File Offset: 0x002607A8
		// (set) Token: 0x06008282 RID: 33410 RVA: 0x002625BC File Offset: 0x002607BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AllianceRelation AllianceRelation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (AllianceRelation)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x06008283 RID: 33411 RVA: 0x002625CC File Offset: 0x002607CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasAllianceRelation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06008284 RID: 33412 RVA: 0x002625DC File Offset: 0x002607DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearAllianceRelation()
		{
		}

		// Token: 0x06008285 RID: 33413 RVA: 0x002625EC File Offset: 0x002607EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008286 RID: 33414 RVA: 0x002625FC File Offset: 0x002607FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTeamMembersInformation other)
		{
			return true;
		}

		// Token: 0x06008287 RID: 33415 RVA: 0x0026260C File Offset: 0x0026080C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008288 RID: 33416 RVA: 0x0026261C File Offset: 0x0026081C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008289 RID: 33417 RVA: 0x0026262C File Offset: 0x0026082C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600828A RID: 33418 RVA: 0x0026263C File Offset: 0x0026083C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600828B RID: 33419 RVA: 0x0026264C File Offset: 0x0026084C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600828C RID: 33420 RVA: 0x0026265C File Offset: 0x0026085C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTeamMembersInformation other)
		{
		}

		// Token: 0x0600828D RID: 33421 RVA: 0x0026266C File Offset: 0x0026086C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600828E RID: 33422 RVA: 0x0026267C File Offset: 0x0026087C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600828F RID: 33423 RVA: 0x0026268C File Offset: 0x0026088C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTeamMembersInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 6;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_3D;
					case 1:
						FightTeamMembersInformation._repeated_teamMembers_codec = FieldCodec.ForMessage<FightTeamMemberInformation>(10U, fxdmNjBIcBsUavXgPEqU.XVInXhlssT(fxdmNjBIcBsUavXgPEqU.c8UBIUYiaOk));
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						FightTeamMembersInformation._parser = new MessageParser<FightTeamMembersInformation>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						break;
					case 4:
						return;
					case 5:
						goto IL_AE;
					case 6:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 5;
						break;
					}
				}
				IL_3D:
				FightTeamMembersInformation.AllianceRelationDefaultValue = AllianceRelation.None;
				num = 4;
				continue;
				IL_AE:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
			}
		}

		// Token: 0x06008290 RID: 33424 RVA: 0x00262798 File Offset: 0x00260998
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pKdqpaJsfRptVieBd4lT()
		{
			return true;
		}

		// Token: 0x06008291 RID: 33425 RVA: 0x002627A0 File Offset: 0x002609A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTeamMembersInformation VuY1jtJsn5MN6u44opre()
		{
			return null;
		}

		// Token: 0x04002F8B RID: 12171
		private static readonly MessageParser<FightTeamMembersInformation> _parser;

		// Token: 0x04002F8C RID: 12172
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F8D RID: 12173
		private int _hasBits0;

		// Token: 0x04002F8E RID: 12174
		public const int TeamMembersFieldNumber = 1;

		// Token: 0x04002F8F RID: 12175
		private static readonly FieldCodec<FightTeamMemberInformation> _repeated_teamMembers_codec;

		// Token: 0x04002F90 RID: 12176
		private readonly RepeatedField<FightTeamMemberInformation> teamMembers_;

		// Token: 0x04002F91 RID: 12177
		public const int AllianceRelationFieldNumber = 2;

		// Token: 0x04002F92 RID: 12178
		private static readonly AllianceRelation AllianceRelationDefaultValue;

		// Token: 0x04002F93 RID: 12179
		private AllianceRelation allianceRelation_;

		// Token: 0x04002F94 RID: 12180
		internal static FightTeamMembersInformation wTeVOZJgzhlWtxsE6xuM;
	}
}
