using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job
{
	// Token: 0x020003C5 RID: 965
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobDescription : IMessage<JobDescription>, IMessage, IEquatable<JobDescription>, IDeepCloneable<JobDescription>, IBufferMessage
	{
		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06002D4C RID: 11596 RVA: 0x001CE420 File Offset: 0x001CC620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JobDescription> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06002D4D RID: 11597 RVA: 0x001CE430 File Offset: 0x001CC630
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

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06002D4E RID: 11598 RVA: 0x001CE440 File Offset: 0x001CC640
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

		// Token: 0x06002D4F RID: 11599 RVA: 0x001CE450 File Offset: 0x001CC650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobDescription()
		{
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x001CE460 File Offset: 0x001CC660
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobDescription(JobDescription other)
		{
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x001CE470 File Offset: 0x001CC670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobDescription Clone()
		{
			return null;
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06002D52 RID: 11602 RVA: 0x001CE480 File Offset: 0x001CC680
		// (set) Token: 0x06002D53 RID: 11603 RVA: 0x001CE490 File Offset: 0x001CC690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int JobId
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

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06002D54 RID: 11604 RVA: 0x001CE4A0 File Offset: 0x001CC6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JobDescription.Types.SkillAction> Skills
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x001CE4B0 File Offset: 0x001CC6B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x001CE4C0 File Offset: 0x001CC6C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobDescription other)
		{
			return true;
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x001CE4D0 File Offset: 0x001CC6D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x001CE4E0 File Offset: 0x001CC6E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x001CE4F0 File Offset: 0x001CC6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x001CE500 File Offset: 0x001CC700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x001CE510 File Offset: 0x001CC710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x001CE520 File Offset: 0x001CC720
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobDescription other)
		{
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x001CE530 File Offset: 0x001CC730
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x001CE540 File Offset: 0x001CC740
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x001CE550 File Offset: 0x001CC750
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobDescription()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						JobDescription._parser = new MessageParser<JobDescription>(() => null);
						num2 = 3;
						continue;
					case 2:
						return;
					case 3:
						goto IL_62;
					case 4:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 1;
					}
				}
				IL_62:
				JobDescription._repeated_skills_codec = FieldCodec.ForMessage<JobDescription.Types.SkillAction>(18U, IG55tEn7KGcZGtRxFMLs.XVInXhlssT(IG55tEn7KGcZGtRxFMLs.J0In7IZOIBd));
				num = 2;
			}
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x001CE65C File Offset: 0x001CC85C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nZ4LxEOVMPXBt3Pcl5ma()
		{
			return true;
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x001CE664 File Offset: 0x001CC864
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobDescription tFgEyROVuXTAX3ZsaCR2()
		{
			return null;
		}

		// Token: 0x04000FE9 RID: 4073
		private static readonly MessageParser<JobDescription> _parser;

		// Token: 0x04000FEA RID: 4074
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FEB RID: 4075
		public const int JobIdFieldNumber = 1;

		// Token: 0x04000FEC RID: 4076
		private int jobId_;

		// Token: 0x04000FED RID: 4077
		public const int SkillsFieldNumber = 2;

		// Token: 0x04000FEE RID: 4078
		private static readonly FieldCodec<JobDescription.Types.SkillAction> _repeated_skills_codec;

		// Token: 0x04000FEF RID: 4079
		private readonly RepeatedField<JobDescription.Types.SkillAction> skills_;

		// Token: 0x04000FF0 RID: 4080
		private static JobDescription DlX1fHOVSP6bXLqBuS4Z;

		// Token: 0x020003C6 RID: 966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06002D62 RID: 11618 RVA: 0x002BB1B8 File Offset: 0x002B93B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020003C7 RID: 967
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class SkillAction : IMessage<JobDescription.Types.SkillAction>, IMessage, IEquatable<JobDescription.Types.SkillAction>, IDeepCloneable<JobDescription.Types.SkillAction>, IBufferMessage
			{
				// Token: 0x17000817 RID: 2071
				// (get) Token: 0x06002D63 RID: 11619 RVA: 0x002FBAD4 File Offset: 0x002F9CD4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<JobDescription.Types.SkillAction> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000818 RID: 2072
				// (get) Token: 0x06002D64 RID: 11620 RVA: 0x002FBAE4 File Offset: 0x002F9CE4
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

				// Token: 0x17000819 RID: 2073
				// (get) Token: 0x06002D65 RID: 11621 RVA: 0x002FBAF4 File Offset: 0x002F9CF4
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

				// Token: 0x06002D66 RID: 11622 RVA: 0x002FBB04 File Offset: 0x002F9D04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SkillAction()
				{
				}

				// Token: 0x06002D67 RID: 11623 RVA: 0x002FBB14 File Offset: 0x002F9D14
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SkillAction(JobDescription.Types.SkillAction other)
				{
				}

				// Token: 0x06002D68 RID: 11624 RVA: 0x002FBB24 File Offset: 0x002F9D24
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public JobDescription.Types.SkillAction Clone()
				{
					return null;
				}

				// Token: 0x1700081A RID: 2074
				// (get) Token: 0x06002D69 RID: 11625 RVA: 0x002FBB34 File Offset: 0x002F9D34
				// (set) Token: 0x06002D6A RID: 11626 RVA: 0x002FBB44 File Offset: 0x002F9D44
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int SkillId
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

				// Token: 0x1700081B RID: 2075
				// (get) Token: 0x06002D6B RID: 11627 RVA: 0x002FBB54 File Offset: 0x002F9D54
				// (set) Token: 0x06002D6C RID: 11628 RVA: 0x002FBB64 File Offset: 0x002F9D64
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public JobDescription.Types.SkillAction.Types.Timed Timed
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

				// Token: 0x1700081C RID: 2076
				// (get) Token: 0x06002D6D RID: 11629 RVA: 0x002FBB74 File Offset: 0x002F9D74
				// (set) Token: 0x06002D6E RID: 11630 RVA: 0x002FBB84 File Offset: 0x002F9D84
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public JobDescription.Types.SkillAction.Types.Craft Craft
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

				// Token: 0x1700081D RID: 2077
				// (get) Token: 0x06002D6F RID: 11631 RVA: 0x002FBB94 File Offset: 0x002F9D94
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public JobDescription.Types.SkillAction.ActionOneofCase ActionCase
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (JobDescription.Types.SkillAction.ActionOneofCase)null;
					}
				}

				// Token: 0x06002D70 RID: 11632 RVA: 0x002FBBA8 File Offset: 0x002F9DA8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearAction()
				{
				}

				// Token: 0x06002D71 RID: 11633 RVA: 0x002FBBB8 File Offset: 0x002F9DB8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06002D72 RID: 11634 RVA: 0x002FBBC8 File Offset: 0x002F9DC8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(JobDescription.Types.SkillAction other)
				{
					return true;
				}

				// Token: 0x06002D73 RID: 11635 RVA: 0x002FBBD8 File Offset: 0x002F9DD8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06002D74 RID: 11636 RVA: 0x002FBBE8 File Offset: 0x002F9DE8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06002D75 RID: 11637 RVA: 0x002FBBF8 File Offset: 0x002F9DF8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06002D76 RID: 11638 RVA: 0x002FBC08 File Offset: 0x002F9E08
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06002D77 RID: 11639 RVA: 0x002FBC18 File Offset: 0x002F9E18
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06002D78 RID: 11640 RVA: 0x002FBC28 File Offset: 0x002F9E28
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(JobDescription.Types.SkillAction other)
				{
				}

				// Token: 0x06002D79 RID: 11641 RVA: 0x002FBC38 File Offset: 0x002F9E38
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06002D7A RID: 11642 RVA: 0x002FBC48 File Offset: 0x002F9E48
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06002D7B RID: 11643 RVA: 0x002FBC58 File Offset: 0x002F9E58
				[MethodImpl(MethodImplOptions.NoInlining)]
				static SkillAction()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 != 0)
							{
								num2 = 2;
							}
							break;
						case 1:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							JobDescription.Types.SkillAction._parser = new MessageParser<JobDescription.Types.SkillAction>(() => null);
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 != 0)
							{
								num2 = 3;
							}
							break;
						case 3:
							return;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 != 0)
							{
								num2 = 2;
							}
							break;
						}
					}
				}

				// Token: 0x06002D7C RID: 11644 RVA: 0x002FBD50 File Offset: 0x002F9F50
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool GU0CchGY0RxNWuwk7TZJ()
				{
					return true;
				}

				// Token: 0x06002D7D RID: 11645 RVA: 0x002FBD58 File Offset: 0x002F9F58
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static JobDescription.Types.SkillAction nwRT7vGYCynsi83NIos6()
				{
					return null;
				}

				// Token: 0x04000FF1 RID: 4081
				private static readonly MessageParser<JobDescription.Types.SkillAction> _parser;

				// Token: 0x04000FF2 RID: 4082
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000FF3 RID: 4083
				public const int SkillIdFieldNumber = 1;

				// Token: 0x04000FF4 RID: 4084
				private int skillId_;

				// Token: 0x04000FF5 RID: 4085
				public const int TimedFieldNumber = 2;

				// Token: 0x04000FF6 RID: 4086
				public const int CraftFieldNumber = 3;

				// Token: 0x04000FF7 RID: 4087
				private object action_;

				// Token: 0x04000FF8 RID: 4088
				private JobDescription.Types.SkillAction.ActionOneofCase actionCase_;

				// Token: 0x04000FF9 RID: 4089
				private static JobDescription.Types.SkillAction rToynuGYV9G8H3timGGU;

				// Token: 0x020003C8 RID: 968
				public enum ActionOneofCase
				{
					// Token: 0x04000FFB RID: 4091
					None,
					// Token: 0x04000FFC RID: 4092
					Timed = 2,
					// Token: 0x04000FFD RID: 4093
					Craft
				}

				// Token: 0x020003C9 RID: 969
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static class Types
				{
					// Token: 0x06002D7E RID: 11646 RVA: 0x00312800 File Offset: 0x00310A00
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x020003CA RID: 970
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class Timed : IMessage<JobDescription.Types.SkillAction.Types.Timed>, IMessage, IEquatable<JobDescription.Types.SkillAction.Types.Timed>, IDeepCloneable<JobDescription.Types.SkillAction.Types.Timed>, IBufferMessage
					{
						// Token: 0x1700081E RID: 2078
						// (get) Token: 0x06002D7F RID: 11647 RVA: 0x0031C018 File Offset: 0x0031A218
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<JobDescription.Types.SkillAction.Types.Timed> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x1700081F RID: 2079
						// (get) Token: 0x06002D80 RID: 11648 RVA: 0x0031C028 File Offset: 0x0031A228
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

						// Token: 0x17000820 RID: 2080
						// (get) Token: 0x06002D81 RID: 11649 RVA: 0x0031C038 File Offset: 0x0031A238
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

						// Token: 0x06002D82 RID: 11650 RVA: 0x0031C048 File Offset: 0x0031A248
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public Timed()
						{
						}

						// Token: 0x06002D83 RID: 11651 RVA: 0x0031C058 File Offset: 0x0031A258
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public Timed(JobDescription.Types.SkillAction.Types.Timed other)
						{
						}

						// Token: 0x06002D84 RID: 11652 RVA: 0x0031C068 File Offset: 0x0031A268
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public JobDescription.Types.SkillAction.Types.Timed Clone()
						{
							return null;
						}

						// Token: 0x17000821 RID: 2081
						// (get) Token: 0x06002D85 RID: 11653 RVA: 0x0031C078 File Offset: 0x0031A278
						// (set) Token: 0x06002D86 RID: 11654 RVA: 0x0031C088 File Offset: 0x0031A288
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public int Time
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

						// Token: 0x17000822 RID: 2082
						// (get) Token: 0x06002D87 RID: 11655 RVA: 0x0031C098 File Offset: 0x0031A298
						// (set) Token: 0x06002D88 RID: 11656 RVA: 0x0031C0A8 File Offset: 0x0031A2A8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public JobDescription.Types.SkillAction.Types.Timed.Types.Collect Collect
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

						// Token: 0x06002D89 RID: 11657 RVA: 0x0031C0B8 File Offset: 0x0031A2B8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x06002D8A RID: 11658 RVA: 0x0031C0C8 File Offset: 0x0031A2C8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(JobDescription.Types.SkillAction.Types.Timed other)
						{
							return true;
						}

						// Token: 0x06002D8B RID: 11659 RVA: 0x0031C0D8 File Offset: 0x0031A2D8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06002D8C RID: 11660 RVA: 0x0031C0E8 File Offset: 0x0031A2E8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06002D8D RID: 11661 RVA: 0x0031C0F8 File Offset: 0x0031A2F8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x06002D8E RID: 11662 RVA: 0x0031C108 File Offset: 0x0031A308
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06002D8F RID: 11663 RVA: 0x0031C118 File Offset: 0x0031A318
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06002D90 RID: 11664 RVA: 0x0031C128 File Offset: 0x0031A328
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(JobDescription.Types.SkillAction.Types.Timed other)
						{
						}

						// Token: 0x06002D91 RID: 11665 RVA: 0x0031C138 File Offset: 0x0031A338
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x06002D92 RID: 11666 RVA: 0x0031C148 File Offset: 0x0031A348
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06002D93 RID: 11667 RVA: 0x0031C158 File Offset: 0x0031A358
						[MethodImpl(MethodImplOptions.NoInlining)]
						static Timed()
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
									num2 = 2;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
									{
										num2 = 4;
										continue;
									}
									continue;
								case 2:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 1;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c != 0)
									{
										num2 = 1;
										continue;
									}
									continue;
								case 3:
									return;
								case 4:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 != 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								}
								JobDescription.Types.SkillAction.Types.Timed._parser = new MessageParser<JobDescription.Types.SkillAction.Types.Timed>(() => null);
								num2 = 3;
							}
						}

						// Token: 0x06002D94 RID: 11668 RVA: 0x0031C23C File Offset: 0x0031A43C
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool l1AV0vgJB8Vj1hQ4pxTN()
						{
							return true;
						}

						// Token: 0x06002D95 RID: 11669 RVA: 0x0031C244 File Offset: 0x0031A444
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static JobDescription.Types.SkillAction.Types.Timed a6jQ7qgJeImmxJK2tHCq()
						{
							return null;
						}

						// Token: 0x04000FFE RID: 4094
						private static readonly MessageParser<JobDescription.Types.SkillAction.Types.Timed> _parser;

						// Token: 0x04000FFF RID: 4095
						private UnknownFieldSet _unknownFields;

						// Token: 0x04001000 RID: 4096
						public const int TimeFieldNumber = 1;

						// Token: 0x04001001 RID: 4097
						private int time_;

						// Token: 0x04001002 RID: 4098
						public const int CollectFieldNumber = 2;

						// Token: 0x04001003 RID: 4099
						private JobDescription.Types.SkillAction.Types.Timed.Types.Collect collect_;

						// Token: 0x04001004 RID: 4100
						private static JobDescription.Types.SkillAction.Types.Timed cD5k14gJANTBtq2nbgHd;

						// Token: 0x020003CB RID: 971
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static class Types
						{
							// Token: 0x06002D96 RID: 11670 RVA: 0x00321084 File Offset: 0x0031F284
							[MethodImpl(MethodImplOptions.NoInlining)]
							static Types()
							{
								uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							}

							// Token: 0x020003CC RID: 972
							[DebuggerDisplay("{ToString(),nq}")]
							public sealed class Collect : IMessage<JobDescription.Types.SkillAction.Types.Timed.Types.Collect>, IMessage, IEquatable<JobDescription.Types.SkillAction.Types.Timed.Types.Collect>, IDeepCloneable<JobDescription.Types.SkillAction.Types.Timed.Types.Collect>, IBufferMessage
							{
								// Token: 0x17000823 RID: 2083
								// (get) Token: 0x06002D97 RID: 11671 RVA: 0x00322FA0 File Offset: 0x003211A0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public static MessageParser<JobDescription.Types.SkillAction.Types.Timed.Types.Collect> Parser
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return null;
									}
								}

								// Token: 0x17000824 RID: 2084
								// (get) Token: 0x06002D98 RID: 11672 RVA: 0x00322FB0 File Offset: 0x003211B0
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

								// Token: 0x17000825 RID: 2085
								// (get) Token: 0x06002D99 RID: 11673 RVA: 0x00322FC0 File Offset: 0x003211C0
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

								// Token: 0x06002D9A RID: 11674 RVA: 0x00322FD0 File Offset: 0x003211D0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public Collect()
								{
								}

								// Token: 0x06002D9B RID: 11675 RVA: 0x00322FE0 File Offset: 0x003211E0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public Collect(JobDescription.Types.SkillAction.Types.Timed.Types.Collect other)
								{
								}

								// Token: 0x06002D9C RID: 11676 RVA: 0x00322FF0 File Offset: 0x003211F0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public JobDescription.Types.SkillAction.Types.Timed.Types.Collect Clone()
								{
									return null;
								}

								// Token: 0x17000826 RID: 2086
								// (get) Token: 0x06002D9D RID: 11677 RVA: 0x00323000 File Offset: 0x00321200
								// (set) Token: 0x06002D9E RID: 11678 RVA: 0x00323010 File Offset: 0x00321210
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public int Min
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

								// Token: 0x17000827 RID: 2087
								// (get) Token: 0x06002D9F RID: 11679 RVA: 0x00323020 File Offset: 0x00321220
								// (set) Token: 0x06002DA0 RID: 11680 RVA: 0x00323030 File Offset: 0x00321230
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public int Max
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

								// Token: 0x06002DA1 RID: 11681 RVA: 0x00323040 File Offset: 0x00321240
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override bool Equals(object other)
								{
									return true;
								}

								// Token: 0x06002DA2 RID: 11682 RVA: 0x00323050 File Offset: 0x00321250
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public bool Equals(JobDescription.Types.SkillAction.Types.Timed.Types.Collect other)
								{
									return true;
								}

								// Token: 0x06002DA3 RID: 11683 RVA: 0x00323060 File Offset: 0x00321260
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override int GetHashCode()
								{
									return 0;
								}

								// Token: 0x06002DA4 RID: 11684 RVA: 0x00323070 File Offset: 0x00321270
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override string ToString()
								{
									return null;
								}

								// Token: 0x06002DA5 RID: 11685 RVA: 0x00323080 File Offset: 0x00321280
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void WriteTo(CodedOutputStream output)
								{
								}

								// Token: 0x06002DA6 RID: 11686 RVA: 0x00323090 File Offset: 0x00321290
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalWriteTo(ref WriteContext output)
								{
								}

								// Token: 0x06002DA7 RID: 11687 RVA: 0x003230A0 File Offset: 0x003212A0
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public int CalculateSize()
								{
									return 0;
								}

								// Token: 0x06002DA8 RID: 11688 RVA: 0x003230B0 File Offset: 0x003212B0
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(JobDescription.Types.SkillAction.Types.Timed.Types.Collect other)
								{
								}

								// Token: 0x06002DA9 RID: 11689 RVA: 0x003230C0 File Offset: 0x003212C0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(CodedInputStream input)
								{
								}

								// Token: 0x06002DAA RID: 11690 RVA: 0x003230D0 File Offset: 0x003212D0
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalMergeFrom(ref ParseContext input)
								{
								}

								// Token: 0x06002DAB RID: 11691 RVA: 0x003230E0 File Offset: 0x003212E0
								[MethodImpl(MethodImplOptions.NoInlining)]
								static Collect()
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
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e == 0)
											{
												num2 = 0;
												continue;
											}
											continue;
										case 2:
											xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
											num2 = 1;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
											{
												num2 = 1;
												continue;
											}
											continue;
										case 3:
											return;
										case 4:
											JobDescription.Types.SkillAction.Types.Timed.Types.Collect._parser = new MessageParser<JobDescription.Types.SkillAction.Types.Timed.Types.Collect>(() => null);
											num2 = 3;
											continue;
										}
										UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
										num2 = 1;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a != 0)
										{
											num2 = 4;
										}
									}
								}

								// Token: 0x06002DAC RID: 11692 RVA: 0x003231C4 File Offset: 0x003213C4
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static bool ErAu8igdoCAEwTKqcjnZ()
								{
									return true;
								}

								// Token: 0x06002DAD RID: 11693 RVA: 0x003231CC File Offset: 0x003213CC
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static JobDescription.Types.SkillAction.Types.Timed.Types.Collect s10JZkgd1tgca9KvNnkn()
								{
									return null;
								}

								// Token: 0x04001005 RID: 4101
								private static readonly MessageParser<JobDescription.Types.SkillAction.Types.Timed.Types.Collect> _parser;

								// Token: 0x04001006 RID: 4102
								private UnknownFieldSet _unknownFields;

								// Token: 0x04001007 RID: 4103
								public const int MinFieldNumber = 1;

								// Token: 0x04001008 RID: 4104
								private int min_;

								// Token: 0x04001009 RID: 4105
								public const int MaxFieldNumber = 2;

								// Token: 0x0400100A RID: 4106
								private int max_;

								// Token: 0x0400100B RID: 4107
								internal static JobDescription.Types.SkillAction.Types.Timed.Types.Collect V8wLavgdvVvsLRQ449L0;
							}
						}
					}

					// Token: 0x020003CF RID: 975
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class Craft : IMessage<JobDescription.Types.SkillAction.Types.Craft>, IMessage, IEquatable<JobDescription.Types.SkillAction.Types.Craft>, IDeepCloneable<JobDescription.Types.SkillAction.Types.Craft>, IBufferMessage
					{
						// Token: 0x17000828 RID: 2088
						// (get) Token: 0x06002DB8 RID: 11704 RVA: 0x0031C24C File Offset: 0x0031A44C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<JobDescription.Types.SkillAction.Types.Craft> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17000829 RID: 2089
						// (get) Token: 0x06002DB9 RID: 11705 RVA: 0x0031C25C File Offset: 0x0031A45C
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

						// Token: 0x1700082A RID: 2090
						// (get) Token: 0x06002DBA RID: 11706 RVA: 0x0031C26C File Offset: 0x0031A46C
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

						// Token: 0x06002DBB RID: 11707 RVA: 0x0031C27C File Offset: 0x0031A47C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public Craft()
						{
						}

						// Token: 0x06002DBC RID: 11708 RVA: 0x0031C28C File Offset: 0x0031A48C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public Craft(JobDescription.Types.SkillAction.Types.Craft other)
						{
						}

						// Token: 0x06002DBD RID: 11709 RVA: 0x0031C29C File Offset: 0x0031A49C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public JobDescription.Types.SkillAction.Types.Craft Clone()
						{
							return null;
						}

						// Token: 0x1700082B RID: 2091
						// (get) Token: 0x06002DBE RID: 11710 RVA: 0x0031C2AC File Offset: 0x0031A4AC
						// (set) Token: 0x06002DBF RID: 11711 RVA: 0x0031C2BC File Offset: 0x0031A4BC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public int Probability
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

						// Token: 0x06002DC0 RID: 11712 RVA: 0x0031C2CC File Offset: 0x0031A4CC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x06002DC1 RID: 11713 RVA: 0x0031C2DC File Offset: 0x0031A4DC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(JobDescription.Types.SkillAction.Types.Craft other)
						{
							return true;
						}

						// Token: 0x06002DC2 RID: 11714 RVA: 0x0031C2EC File Offset: 0x0031A4EC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06002DC3 RID: 11715 RVA: 0x0031C2FC File Offset: 0x0031A4FC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06002DC4 RID: 11716 RVA: 0x0031C30C File Offset: 0x0031A50C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x06002DC5 RID: 11717 RVA: 0x0031C31C File Offset: 0x0031A51C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06002DC6 RID: 11718 RVA: 0x0031C32C File Offset: 0x0031A52C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06002DC7 RID: 11719 RVA: 0x0031C33C File Offset: 0x0031A53C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(JobDescription.Types.SkillAction.Types.Craft other)
						{
						}

						// Token: 0x06002DC8 RID: 11720 RVA: 0x0031C34C File Offset: 0x0031A54C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x06002DC9 RID: 11721 RVA: 0x0031C35C File Offset: 0x0031A55C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06002DCA RID: 11722 RVA: 0x0031C36C File Offset: 0x0031A56C
						[MethodImpl(MethodImplOptions.NoInlining)]
						static Craft()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 1;
							int num2 = num;
							for (;;)
							{
								switch (num2)
								{
								case 1:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 != 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								case 2:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 4;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
									{
										num2 = 2;
										continue;
									}
									continue;
								case 3:
									return;
								case 4:
									JobDescription.Types.SkillAction.Types.Craft._parser = new MessageParser<JobDescription.Types.SkillAction.Types.Craft>(() => null);
									num2 = 3;
									continue;
								}
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 2;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
								{
									num2 = 1;
								}
							}
						}

						// Token: 0x06002DCB RID: 11723 RVA: 0x0031C450 File Offset: 0x0031A650
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool gWOSwMgJRgFbqVSM044h()
						{
							return true;
						}

						// Token: 0x06002DCC RID: 11724 RVA: 0x0031C458 File Offset: 0x0031A658
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static JobDescription.Types.SkillAction.Types.Craft KWIrEGgJO93AX1EBK9gU()
						{
							return null;
						}

						// Token: 0x04001010 RID: 4112
						private static readonly MessageParser<JobDescription.Types.SkillAction.Types.Craft> _parser;

						// Token: 0x04001011 RID: 4113
						private UnknownFieldSet _unknownFields;

						// Token: 0x04001012 RID: 4114
						public const int ProbabilityFieldNumber = 1;

						// Token: 0x04001013 RID: 4115
						private int probability_;

						// Token: 0x04001014 RID: 4116
						private static JobDescription.Types.SkillAction.Types.Craft wabHGDgJ3nc6VpTbPRF6;
					}
				}
			}
		}
	}
}
