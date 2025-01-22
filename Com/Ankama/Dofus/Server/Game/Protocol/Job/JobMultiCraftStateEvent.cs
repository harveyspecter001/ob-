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
	// Token: 0x020003B1 RID: 945
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobMultiCraftStateEvent : IMessage<JobMultiCraftStateEvent>, IMessage, IEquatable<JobMultiCraftStateEvent>, IDeepCloneable<JobMultiCraftStateEvent>, IBufferMessage
	{
		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06002C59 RID: 11353 RVA: 0x001CD50C File Offset: 0x001CB70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JobMultiCraftStateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06002C5A RID: 11354 RVA: 0x001CD51C File Offset: 0x001CB71C
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

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06002C5B RID: 11355 RVA: 0x001CD52C File Offset: 0x001CB72C
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

		// Token: 0x06002C5C RID: 11356 RVA: 0x001CD53C File Offset: 0x001CB73C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobMultiCraftStateEvent()
		{
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x001CD54C File Offset: 0x001CB74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobMultiCraftStateEvent(JobMultiCraftStateEvent other)
		{
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x001CD55C File Offset: 0x001CB75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobMultiCraftStateEvent Clone()
		{
			return null;
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06002C5F RID: 11359 RVA: 0x001CD56C File Offset: 0x001CB76C
		// (set) Token: 0x06002C60 RID: 11360 RVA: 0x001CD57C File Offset: 0x001CB77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Enabled
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

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06002C61 RID: 11361 RVA: 0x001CD58C File Offset: 0x001CB78C
		// (set) Token: 0x06002C62 RID: 11362 RVA: 0x001CD59C File Offset: 0x001CB79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JobMultiCraftStateEvent.Types.PlayerSkills PlayerSkills
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

		// Token: 0x06002C63 RID: 11363 RVA: 0x001CD5AC File Offset: 0x001CB7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x001CD5BC File Offset: 0x001CB7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobMultiCraftStateEvent other)
		{
			return true;
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x001CD5CC File Offset: 0x001CB7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x001CD5DC File Offset: 0x001CB7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x001CD5EC File Offset: 0x001CB7EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x001CD5FC File Offset: 0x001CB7FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x001CD60C File Offset: 0x001CB80C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x001CD61C File Offset: 0x001CB81C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobMultiCraftStateEvent other)
		{
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x001CD62C File Offset: 0x001CB82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x001CD63C File Offset: 0x001CB83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x001CD64C File Offset: 0x001CB84C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobMultiCraftStateEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					JobMultiCraftStateEvent._parser = new MessageParser<JobMultiCraftStateEvent>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x001CD718 File Offset: 0x001CB918
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d7RhamOV6qspxvyfMiQi()
		{
			return true;
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x001CD720 File Offset: 0x001CB920
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobMultiCraftStateEvent wdnrlkOVLW8YrHtmjSSs()
		{
			return null;
		}

		// Token: 0x04000F99 RID: 3993
		private static readonly MessageParser<JobMultiCraftStateEvent> _parser;

		// Token: 0x04000F9A RID: 3994
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F9B RID: 3995
		public const int EnabledFieldNumber = 1;

		// Token: 0x04000F9C RID: 3996
		private bool enabled_;

		// Token: 0x04000F9D RID: 3997
		public const int PlayerSkillsFieldNumber = 2;

		// Token: 0x04000F9E RID: 3998
		private JobMultiCraftStateEvent.Types.PlayerSkills playerSkills_;

		// Token: 0x04000F9F RID: 3999
		internal static JobMultiCraftStateEvent tls6wsOVy2kVjIx0ikwb;

		// Token: 0x020003B2 RID: 946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06002C70 RID: 11376 RVA: 0x002BAAF0 File Offset: 0x002B8CF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020003B3 RID: 947
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class PlayerSkills : IMessage<JobMultiCraftStateEvent.Types.PlayerSkills>, IMessage, IEquatable<JobMultiCraftStateEvent.Types.PlayerSkills>, IDeepCloneable<JobMultiCraftStateEvent.Types.PlayerSkills>, IBufferMessage
			{
				// Token: 0x170007ED RID: 2029
				// (get) Token: 0x06002C71 RID: 11377 RVA: 0x002FB660 File Offset: 0x002F9860
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<JobMultiCraftStateEvent.Types.PlayerSkills> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170007EE RID: 2030
				// (get) Token: 0x06002C72 RID: 11378 RVA: 0x002FB670 File Offset: 0x002F9870
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

				// Token: 0x170007EF RID: 2031
				// (get) Token: 0x06002C73 RID: 11379 RVA: 0x002FB680 File Offset: 0x002F9880
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

				// Token: 0x06002C74 RID: 11380 RVA: 0x002FB690 File Offset: 0x002F9890
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PlayerSkills()
				{
				}

				// Token: 0x06002C75 RID: 11381 RVA: 0x002FB6A0 File Offset: 0x002F98A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PlayerSkills(JobMultiCraftStateEvent.Types.PlayerSkills other)
				{
				}

				// Token: 0x06002C76 RID: 11382 RVA: 0x002FB6B0 File Offset: 0x002F98B0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public JobMultiCraftStateEvent.Types.PlayerSkills Clone()
				{
					return null;
				}

				// Token: 0x170007F0 RID: 2032
				// (get) Token: 0x06002C77 RID: 11383 RVA: 0x002FB6C0 File Offset: 0x002F98C0
				// (set) Token: 0x06002C78 RID: 11384 RVA: 0x002FB6D0 File Offset: 0x002F98D0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long PlayerId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x170007F1 RID: 2033
				// (get) Token: 0x06002C79 RID: 11385 RVA: 0x002FB6E0 File Offset: 0x002F98E0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public RepeatedField<int> Skills
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x06002C7A RID: 11386 RVA: 0x002FB6F0 File Offset: 0x002F98F0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06002C7B RID: 11387 RVA: 0x002FB700 File Offset: 0x002F9900
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(JobMultiCraftStateEvent.Types.PlayerSkills other)
				{
					return true;
				}

				// Token: 0x06002C7C RID: 11388 RVA: 0x002FB710 File Offset: 0x002F9910
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06002C7D RID: 11389 RVA: 0x002FB720 File Offset: 0x002F9920
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06002C7E RID: 11390 RVA: 0x002FB730 File Offset: 0x002F9930
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06002C7F RID: 11391 RVA: 0x002FB740 File Offset: 0x002F9940
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06002C80 RID: 11392 RVA: 0x002FB750 File Offset: 0x002F9950
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06002C81 RID: 11393 RVA: 0x002FB760 File Offset: 0x002F9960
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(JobMultiCraftStateEvent.Types.PlayerSkills other)
				{
				}

				// Token: 0x06002C82 RID: 11394 RVA: 0x002FB770 File Offset: 0x002F9970
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06002C83 RID: 11395 RVA: 0x002FB780 File Offset: 0x002F9980
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06002C84 RID: 11396 RVA: 0x002FB790 File Offset: 0x002F9990
				[MethodImpl(MethodImplOptions.NoInlining)]
				static PlayerSkills()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							JobMultiCraftStateEvent.Types.PlayerSkills._parser = new MessageParser<JobMultiCraftStateEvent.Types.PlayerSkills>(() => null);
							num2 = 5;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						case 2:
							return;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							continue;
						case 5:
							JobMultiCraftStateEvent.Types.PlayerSkills._repeated_skills_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 != 0)
						{
							num2 = 0;
						}
					}
				}

				// Token: 0x06002C85 RID: 11397 RVA: 0x002FB8A8 File Offset: 0x002F9AA8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool UwmrfWGY6W2C6Krk3u6E()
				{
					return true;
				}

				// Token: 0x06002C86 RID: 11398 RVA: 0x002FB8B0 File Offset: 0x002F9AB0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static JobMultiCraftStateEvent.Types.PlayerSkills kcVYNyGYL2bmYhrMc7eu()
				{
					return null;
				}

				// Token: 0x04000FA0 RID: 4000
				private static readonly MessageParser<JobMultiCraftStateEvent.Types.PlayerSkills> _parser;

				// Token: 0x04000FA1 RID: 4001
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000FA2 RID: 4002
				public const int PlayerIdFieldNumber = 1;

				// Token: 0x04000FA3 RID: 4003
				private long playerId_;

				// Token: 0x04000FA4 RID: 4004
				public const int SkillsFieldNumber = 2;

				// Token: 0x04000FA5 RID: 4005
				private static readonly FieldCodec<int> _repeated_skills_codec;

				// Token: 0x04000FA6 RID: 4006
				private readonly RepeatedField<int> skills_;

				// Token: 0x04000FA7 RID: 4007
				private static JobMultiCraftStateEvent.Types.PlayerSkills ASBgesGYyHqDu15sgqbG;
			}
		}
	}
}
