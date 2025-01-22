using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000AAF RID: 2735
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTeamMemberCharacter : IMessage<FightTeamMemberCharacter>, IMessage, IEquatable<FightTeamMemberCharacter>, IDeepCloneable<FightTeamMemberCharacter>, IBufferMessage
	{
		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x060082BB RID: 33467 RVA: 0x00262A74 File Offset: 0x00260C74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightTeamMemberCharacter> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x060082BC RID: 33468 RVA: 0x00262A84 File Offset: 0x00260C84
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

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x060082BD RID: 33469 RVA: 0x00262A94 File Offset: 0x00260C94
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

		// Token: 0x060082BE RID: 33470 RVA: 0x00262AA4 File Offset: 0x00260CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamMemberCharacter()
		{
		}

		// Token: 0x060082BF RID: 33471 RVA: 0x00262AB4 File Offset: 0x00260CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamMemberCharacter(FightTeamMemberCharacter other)
		{
		}

		// Token: 0x060082C0 RID: 33472 RVA: 0x00262AC4 File Offset: 0x00260CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamMemberCharacter Clone()
		{
			return null;
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x060082C1 RID: 33473 RVA: 0x00262AD4 File Offset: 0x00260CD4
		// (set) Token: 0x060082C2 RID: 33474 RVA: 0x00262AE4 File Offset: 0x00260CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
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

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x060082C3 RID: 33475 RVA: 0x00262AF4 File Offset: 0x00260CF4
		// (set) Token: 0x060082C4 RID: 33476 RVA: 0x00262B04 File Offset: 0x00260D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
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

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x060082C5 RID: 33477 RVA: 0x00262B14 File Offset: 0x00260D14
		// (set) Token: 0x060082C6 RID: 33478 RVA: 0x00262B24 File Offset: 0x00260D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightTeamMemberCharacter.Types.BasicAllianceInformation AllianceInfo
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

		// Token: 0x060082C7 RID: 33479 RVA: 0x00262B34 File Offset: 0x00260D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060082C8 RID: 33480 RVA: 0x00262B44 File Offset: 0x00260D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTeamMemberCharacter other)
		{
			return true;
		}

		// Token: 0x060082C9 RID: 33481 RVA: 0x00262B54 File Offset: 0x00260D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060082CA RID: 33482 RVA: 0x00262B64 File Offset: 0x00260D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060082CB RID: 33483 RVA: 0x00262B74 File Offset: 0x00260D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060082CC RID: 33484 RVA: 0x00262B84 File Offset: 0x00260D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060082CD RID: 33485 RVA: 0x00262B94 File Offset: 0x00260D94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060082CE RID: 33486 RVA: 0x00262BA4 File Offset: 0x00260DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTeamMemberCharacter other)
		{
		}

		// Token: 0x060082CF RID: 33487 RVA: 0x00262BB4 File Offset: 0x00260DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060082D0 RID: 33488 RVA: 0x00262BC4 File Offset: 0x00260DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060082D1 RID: 33489 RVA: 0x00262BD4 File Offset: 0x00260DD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTeamMemberCharacter()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						FightTeamMemberCharacter._parser = new MessageParser<FightTeamMemberCharacter>(() => null);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						goto IL_88;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d != 0)
					{
						num2 = 4;
					}
				}
				IL_88:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 3;
			}
		}

		// Token: 0x060082D2 RID: 33490 RVA: 0x00262CBC File Offset: 0x00260EBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U4leQOJs3CLICBCKCuWH()
		{
			return true;
		}

		// Token: 0x060082D3 RID: 33491 RVA: 0x00262CC4 File Offset: 0x00260EC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTeamMemberCharacter lo0iKpJsRcStkvOJDmAl()
		{
			return null;
		}

		// Token: 0x04002FAA RID: 12202
		private static readonly MessageParser<FightTeamMemberCharacter> _parser;

		// Token: 0x04002FAB RID: 12203
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FAC RID: 12204
		public const int NameFieldNumber = 1;

		// Token: 0x04002FAD RID: 12205
		private string name_;

		// Token: 0x04002FAE RID: 12206
		public const int LevelFieldNumber = 2;

		// Token: 0x04002FAF RID: 12207
		private int level_;

		// Token: 0x04002FB0 RID: 12208
		public const int AllianceInfoFieldNumber = 3;

		// Token: 0x04002FB1 RID: 12209
		private FightTeamMemberCharacter.Types.BasicAllianceInformation allianceInfo_;

		// Token: 0x04002FB2 RID: 12210
		internal static FightTeamMemberCharacter Aa6r8iJseOwn2LPib6ua;

		// Token: 0x02000AB0 RID: 2736
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x060082D4 RID: 33492 RVA: 0x002E17A8 File Offset: 0x002DF9A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000AB1 RID: 2737
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class BasicAllianceInformation : IMessage<FightTeamMemberCharacter.Types.BasicAllianceInformation>, IMessage, IEquatable<FightTeamMemberCharacter.Types.BasicAllianceInformation>, IDeepCloneable<FightTeamMemberCharacter.Types.BasicAllianceInformation>, IBufferMessage
			{
				// Token: 0x170017F2 RID: 6130
				// (get) Token: 0x060082D5 RID: 33493 RVA: 0x0030895C File Offset: 0x00306B5C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<FightTeamMemberCharacter.Types.BasicAllianceInformation> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170017F3 RID: 6131
				// (get) Token: 0x060082D6 RID: 33494 RVA: 0x0030896C File Offset: 0x00306B6C
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

				// Token: 0x170017F4 RID: 6132
				// (get) Token: 0x060082D7 RID: 33495 RVA: 0x0030897C File Offset: 0x00306B7C
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

				// Token: 0x060082D8 RID: 33496 RVA: 0x0030898C File Offset: 0x00306B8C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public BasicAllianceInformation()
				{
				}

				// Token: 0x060082D9 RID: 33497 RVA: 0x0030899C File Offset: 0x00306B9C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public BasicAllianceInformation(FightTeamMemberCharacter.Types.BasicAllianceInformation other)
				{
				}

				// Token: 0x060082DA RID: 33498 RVA: 0x003089AC File Offset: 0x00306BAC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FightTeamMemberCharacter.Types.BasicAllianceInformation Clone()
				{
					return null;
				}

				// Token: 0x170017F5 RID: 6133
				// (get) Token: 0x060082DB RID: 33499 RVA: 0x003089BC File Offset: 0x00306BBC
				// (set) Token: 0x060082DC RID: 33500 RVA: 0x003089CC File Offset: 0x00306BCC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string AllianceUid
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

				// Token: 0x170017F6 RID: 6134
				// (get) Token: 0x060082DD RID: 33501 RVA: 0x003089DC File Offset: 0x00306BDC
				// (set) Token: 0x060082DE RID: 33502 RVA: 0x003089EC File Offset: 0x00306BEC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string AllianceTag
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

				// Token: 0x060082DF RID: 33503 RVA: 0x003089FC File Offset: 0x00306BFC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060082E0 RID: 33504 RVA: 0x00308A0C File Offset: 0x00306C0C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(FightTeamMemberCharacter.Types.BasicAllianceInformation other)
				{
					return true;
				}

				// Token: 0x060082E1 RID: 33505 RVA: 0x00308A1C File Offset: 0x00306C1C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060082E2 RID: 33506 RVA: 0x00308A2C File Offset: 0x00306C2C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060082E3 RID: 33507 RVA: 0x00308A3C File Offset: 0x00306C3C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060082E4 RID: 33508 RVA: 0x00308A4C File Offset: 0x00306C4C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060082E5 RID: 33509 RVA: 0x00308A5C File Offset: 0x00306C5C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060082E6 RID: 33510 RVA: 0x00308A6C File Offset: 0x00306C6C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(FightTeamMemberCharacter.Types.BasicAllianceInformation other)
				{
				}

				// Token: 0x060082E7 RID: 33511 RVA: 0x00308A7C File Offset: 0x00306C7C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060082E8 RID: 33512 RVA: 0x00308A8C File Offset: 0x00306C8C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060082E9 RID: 33513 RVA: 0x00308A9C File Offset: 0x00306C9C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static BasicAllianceInformation()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							FightTeamMemberCharacter.Types.BasicAllianceInformation._parser = new MessageParser<FightTeamMemberCharacter.Types.BasicAllianceInformation>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
							{
								num2 = 1;
							}
							break;
						case 1:
							return;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
							{
								num2 = 0;
							}
							break;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
							{
								num2 = 0;
							}
							break;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							break;
						}
					}
				}

				// Token: 0x060082EA RID: 33514 RVA: 0x00308B80 File Offset: 0x00306D80
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool VKfmZqGuhZOuw3SduSR0()
				{
					return true;
				}

				// Token: 0x060082EB RID: 33515 RVA: 0x00308B88 File Offset: 0x00306D88
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static FightTeamMemberCharacter.Types.BasicAllianceInformation zwulSYGurKBO9nyK9T6b()
				{
					return null;
				}

				// Token: 0x04002FB3 RID: 12211
				private static readonly MessageParser<FightTeamMemberCharacter.Types.BasicAllianceInformation> _parser;

				// Token: 0x04002FB4 RID: 12212
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002FB5 RID: 12213
				public const int AllianceUidFieldNumber = 1;

				// Token: 0x04002FB6 RID: 12214
				private string allianceUid_;

				// Token: 0x04002FB7 RID: 12215
				public const int AllianceTagFieldNumber = 2;

				// Token: 0x04002FB8 RID: 12216
				private string allianceTag_;

				// Token: 0x04002FB9 RID: 12217
				internal static FightTeamMemberCharacter.Types.BasicAllianceInformation DlAHibGuWFB5YvXqSvXd;
			}
		}
	}
}
