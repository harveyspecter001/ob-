using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B04 RID: 2820
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildLogbookEntry : IMessage<GuildLogbookEntry>, IMessage, IEquatable<GuildLogbookEntry>, IDeepCloneable<GuildLogbookEntry>, IBufferMessage
	{
		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x060086F2 RID: 34546 RVA: 0x00265B0C File Offset: 0x00263D0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildLogbookEntry> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x060086F3 RID: 34547 RVA: 0x00265B1C File Offset: 0x00263D1C
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

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x060086F4 RID: 34548 RVA: 0x00265B2C File Offset: 0x00263D2C
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

		// Token: 0x060086F5 RID: 34549 RVA: 0x00265B3C File Offset: 0x00263D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildLogbookEntry()
		{
		}

		// Token: 0x060086F6 RID: 34550 RVA: 0x00265B4C File Offset: 0x00263D4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildLogbookEntry(GuildLogbookEntry other)
		{
		}

		// Token: 0x060086F7 RID: 34551 RVA: 0x00265B5C File Offset: 0x00263D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildLogbookEntry Clone()
		{
			return null;
		}

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x060086F8 RID: 34552 RVA: 0x00265B6C File Offset: 0x00263D6C
		// (set) Token: 0x060086F9 RID: 34553 RVA: 0x00265B7C File Offset: 0x00263D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GuildId
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

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x060086FA RID: 34554 RVA: 0x00265B8C File Offset: 0x00263D8C
		// (set) Token: 0x060086FB RID: 34555 RVA: 0x00265B9C File Offset: 0x00263D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Date
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

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x060086FC RID: 34556 RVA: 0x00265BAC File Offset: 0x00263DAC
		// (set) Token: 0x060086FD RID: 34557 RVA: 0x00265BBC File Offset: 0x00263DBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GuildLogbookEntry.Types.ChestActivity ChestActivity
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

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x060086FE RID: 34558 RVA: 0x00265BCC File Offset: 0x00263DCC
		// (set) Token: 0x060086FF RID: 34559 RVA: 0x00265BDC File Offset: 0x00263DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuildLogbookEntry.Types.PaddockActivity PaddockActivity
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

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x06008700 RID: 34560 RVA: 0x00265BEC File Offset: 0x00263DEC
		// (set) Token: 0x06008701 RID: 34561 RVA: 0x00265BFC File Offset: 0x00263DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuildLogbookEntry.Types.PlayerFlowActivity PlayerFlowActivity
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

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06008702 RID: 34562 RVA: 0x00265C0C File Offset: 0x00263E0C
		// (set) Token: 0x06008703 RID: 34563 RVA: 0x00265C1C File Offset: 0x00263E1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GuildLogbookEntry.Types.LevelUpActivity LevelUpActivity
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

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x06008704 RID: 34564 RVA: 0x00265C2C File Offset: 0x00263E2C
		// (set) Token: 0x06008705 RID: 34565 RVA: 0x00265C3C File Offset: 0x00263E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuildLogbookEntry.Types.UnlockNewTabActivity UnlockNewTabActivity
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

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x06008706 RID: 34566 RVA: 0x00265C4C File Offset: 0x00263E4C
		// (set) Token: 0x06008707 RID: 34567 RVA: 0x00265C5C File Offset: 0x00263E5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GuildLogbookEntry.Types.RankActivity RankActivity
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

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x06008708 RID: 34568 RVA: 0x00265C6C File Offset: 0x00263E6C
		// (set) Token: 0x06008709 RID: 34569 RVA: 0x00265C7C File Offset: 0x00263E7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GuildLogbookEntry.Types.PlayerRankUpdateActivity PlayerRankUpdateActivity
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

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x0600870A RID: 34570 RVA: 0x00265C8C File Offset: 0x00263E8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GuildLogbookEntry.ActivityOneofCase ActivityCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (GuildLogbookEntry.ActivityOneofCase)null;
			}
		}

		// Token: 0x0600870B RID: 34571 RVA: 0x00265CA0 File Offset: 0x00263EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearActivity()
		{
		}

		// Token: 0x0600870C RID: 34572 RVA: 0x00265CB0 File Offset: 0x00263EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600870D RID: 34573 RVA: 0x00265CC0 File Offset: 0x00263EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildLogbookEntry other)
		{
			return true;
		}

		// Token: 0x0600870E RID: 34574 RVA: 0x00265CD0 File Offset: 0x00263ED0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600870F RID: 34575 RVA: 0x00265CE0 File Offset: 0x00263EE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008710 RID: 34576 RVA: 0x00265CF0 File Offset: 0x00263EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008711 RID: 34577 RVA: 0x00265D00 File Offset: 0x00263F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008712 RID: 34578 RVA: 0x00265D10 File Offset: 0x00263F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008713 RID: 34579 RVA: 0x00265D20 File Offset: 0x00263F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildLogbookEntry other)
		{
		}

		// Token: 0x06008714 RID: 34580 RVA: 0x00265D30 File Offset: 0x00263F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008715 RID: 34581 RVA: 0x00265D40 File Offset: 0x00263F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008716 RID: 34582 RVA: 0x00265D50 File Offset: 0x00263F50
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildLogbookEntry()
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
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						GuildLogbookEntry._parser = new MessageParser<GuildLogbookEntry>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_C1;
					}
					return;
				}
				IL_C1:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 3;
			}
		}

		// Token: 0x06008717 RID: 34583 RVA: 0x00265E38 File Offset: 0x00264038
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lgEwvbJdnXuy9ygLTiZo()
		{
			return true;
		}

		// Token: 0x06008718 RID: 34584 RVA: 0x00265E40 File Offset: 0x00264040
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildLogbookEntry p71hx8Jdmg9TJGgpxWO8()
		{
			return null;
		}

		// Token: 0x04003184 RID: 12676
		private static readonly MessageParser<GuildLogbookEntry> _parser;

		// Token: 0x04003185 RID: 12677
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003186 RID: 12678
		public const int GuildIdFieldNumber = 1;

		// Token: 0x04003187 RID: 12679
		private int guildId_;

		// Token: 0x04003188 RID: 12680
		public const int DateFieldNumber = 2;

		// Token: 0x04003189 RID: 12681
		private long date_;

		// Token: 0x0400318A RID: 12682
		public const int ChestActivityFieldNumber = 3;

		// Token: 0x0400318B RID: 12683
		public const int PaddockActivityFieldNumber = 4;

		// Token: 0x0400318C RID: 12684
		public const int PlayerFlowActivityFieldNumber = 5;

		// Token: 0x0400318D RID: 12685
		public const int LevelUpActivityFieldNumber = 6;

		// Token: 0x0400318E RID: 12686
		public const int UnlockNewTabActivityFieldNumber = 7;

		// Token: 0x0400318F RID: 12687
		public const int RankActivityFieldNumber = 8;

		// Token: 0x04003190 RID: 12688
		public const int PlayerRankUpdateActivityFieldNumber = 9;

		// Token: 0x04003191 RID: 12689
		private object activity_;

		// Token: 0x04003192 RID: 12690
		private GuildLogbookEntry.ActivityOneofCase activityCase_;

		// Token: 0x04003193 RID: 12691
		private static GuildLogbookEntry zwOSFlJdfPfGAleKT9kA;

		// Token: 0x02000B05 RID: 2821
		public enum ActivityOneofCase
		{
			// Token: 0x04003195 RID: 12693
			None,
			// Token: 0x04003196 RID: 12694
			ChestActivity = 3,
			// Token: 0x04003197 RID: 12695
			PaddockActivity,
			// Token: 0x04003198 RID: 12696
			PlayerFlowActivity,
			// Token: 0x04003199 RID: 12697
			LevelUpActivity,
			// Token: 0x0400319A RID: 12698
			UnlockNewTabActivity,
			// Token: 0x0400319B RID: 12699
			RankActivity,
			// Token: 0x0400319C RID: 12700
			PlayerRankUpdateActivity
		}

		// Token: 0x02000B06 RID: 2822
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06008719 RID: 34585 RVA: 0x002E2A5C File Offset: 0x002E0C5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000B07 RID: 2823
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ChestActivity : IMessage<GuildLogbookEntry.Types.ChestActivity>, IMessage, IEquatable<GuildLogbookEntry.Types.ChestActivity>, IDeepCloneable<GuildLogbookEntry.Types.ChestActivity>, IBufferMessage
			{
				// Token: 0x170018EA RID: 6378
				// (get) Token: 0x0600871A RID: 34586 RVA: 0x0030975C File Offset: 0x0030795C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GuildLogbookEntry.Types.ChestActivity> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170018EB RID: 6379
				// (get) Token: 0x0600871B RID: 34587 RVA: 0x0030976C File Offset: 0x0030796C
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

				// Token: 0x170018EC RID: 6380
				// (get) Token: 0x0600871C RID: 34588 RVA: 0x0030977C File Offset: 0x0030797C
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

				// Token: 0x0600871D RID: 34589 RVA: 0x0030978C File Offset: 0x0030798C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ChestActivity()
				{
				}

				// Token: 0x0600871E RID: 34590 RVA: 0x0030979C File Offset: 0x0030799C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ChestActivity(GuildLogbookEntry.Types.ChestActivity other)
				{
				}

				// Token: 0x0600871F RID: 34591 RVA: 0x003097AC File Offset: 0x003079AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GuildLogbookEntry.Types.ChestActivity Clone()
				{
					return null;
				}

				// Token: 0x170018ED RID: 6381
				// (get) Token: 0x06008720 RID: 34592 RVA: 0x003097BC File Offset: 0x003079BC
				// (set) Token: 0x06008721 RID: 34593 RVA: 0x003097CC File Offset: 0x003079CC
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

				// Token: 0x170018EE RID: 6382
				// (get) Token: 0x06008722 RID: 34594 RVA: 0x003097DC File Offset: 0x003079DC
				// (set) Token: 0x06008723 RID: 34595 RVA: 0x003097EC File Offset: 0x003079EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string PlayerName
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

				// Token: 0x170018EF RID: 6383
				// (get) Token: 0x06008724 RID: 34596 RVA: 0x003097FC File Offset: 0x003079FC
				// (set) Token: 0x06008725 RID: 34597 RVA: 0x00309810 File Offset: 0x00307A10
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public GuildLogbookEntry.Types.ChestActivity.Types.ChestEventType EventType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (GuildLogbookEntry.Types.ChestActivity.Types.ChestEventType)null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x170018F0 RID: 6384
				// (get) Token: 0x06008726 RID: 34598 RVA: 0x00309820 File Offset: 0x00307A20
				// (set) Token: 0x06008727 RID: 34599 RVA: 0x00309830 File Offset: 0x00307A30
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Quantity
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

				// Token: 0x170018F1 RID: 6385
				// (get) Token: 0x06008728 RID: 34600 RVA: 0x00309840 File Offset: 0x00307A40
				// (set) Token: 0x06008729 RID: 34601 RVA: 0x00309850 File Offset: 0x00307A50
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public ObjectItem Object
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

				// Token: 0x170018F2 RID: 6386
				// (get) Token: 0x0600872A RID: 34602 RVA: 0x00309860 File Offset: 0x00307A60
				// (set) Token: 0x0600872B RID: 34603 RVA: 0x00309870 File Offset: 0x00307A70
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int SourceTabId
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

				// Token: 0x170018F3 RID: 6387
				// (get) Token: 0x0600872C RID: 34604 RVA: 0x00309880 File Offset: 0x00307A80
				// (set) Token: 0x0600872D RID: 34605 RVA: 0x00309890 File Offset: 0x00307A90
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int DestinationTabId
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

				// Token: 0x0600872E RID: 34606 RVA: 0x003098A0 File Offset: 0x00307AA0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600872F RID: 34607 RVA: 0x003098B0 File Offset: 0x00307AB0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GuildLogbookEntry.Types.ChestActivity other)
				{
					return true;
				}

				// Token: 0x06008730 RID: 34608 RVA: 0x003098C0 File Offset: 0x00307AC0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008731 RID: 34609 RVA: 0x003098D0 File Offset: 0x00307AD0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008732 RID: 34610 RVA: 0x003098E0 File Offset: 0x00307AE0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008733 RID: 34611 RVA: 0x003098F0 File Offset: 0x00307AF0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008734 RID: 34612 RVA: 0x00309900 File Offset: 0x00307B00
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008735 RID: 34613 RVA: 0x00309910 File Offset: 0x00307B10
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GuildLogbookEntry.Types.ChestActivity other)
				{
				}

				// Token: 0x06008736 RID: 34614 RVA: 0x00309920 File Offset: 0x00307B20
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008737 RID: 34615 RVA: 0x00309930 File Offset: 0x00307B30
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008738 RID: 34616 RVA: 0x00309940 File Offset: 0x00307B40
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ChestActivity()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							return;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 != 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						GuildLogbookEntry.Types.ChestActivity._parser = new MessageParser<GuildLogbookEntry.Types.ChestActivity>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x06008739 RID: 34617 RVA: 0x00309A24 File Offset: 0x00307C24
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool Tdf4iFGuztpGIR9Pss00()
				{
					return true;
				}

				// Token: 0x0600873A RID: 34618 RVA: 0x00309A2C File Offset: 0x00307C2C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GuildLogbookEntry.Types.ChestActivity CLZ03EG8fAUSsBq4423n()
				{
					return null;
				}

				// Token: 0x0400319D RID: 12701
				private static readonly MessageParser<GuildLogbookEntry.Types.ChestActivity> _parser;

				// Token: 0x0400319E RID: 12702
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400319F RID: 12703
				public const int PlayerIdFieldNumber = 1;

				// Token: 0x040031A0 RID: 12704
				private long playerId_;

				// Token: 0x040031A1 RID: 12705
				public const int PlayerNameFieldNumber = 2;

				// Token: 0x040031A2 RID: 12706
				private string playerName_;

				// Token: 0x040031A3 RID: 12707
				public const int EventTypeFieldNumber = 3;

				// Token: 0x040031A4 RID: 12708
				private GuildLogbookEntry.Types.ChestActivity.Types.ChestEventType eventType_;

				// Token: 0x040031A5 RID: 12709
				public const int QuantityFieldNumber = 4;

				// Token: 0x040031A6 RID: 12710
				private int quantity_;

				// Token: 0x040031A7 RID: 12711
				public const int ObjectFieldNumber = 5;

				// Token: 0x040031A8 RID: 12712
				private ObjectItem object_;

				// Token: 0x040031A9 RID: 12713
				public const int SourceTabIdFieldNumber = 6;

				// Token: 0x040031AA RID: 12714
				private int sourceTabId_;

				// Token: 0x040031AB RID: 12715
				public const int DestinationTabIdFieldNumber = 7;

				// Token: 0x040031AC RID: 12716
				private int destinationTabId_;

				// Token: 0x040031AD RID: 12717
				private static GuildLogbookEntry.Types.ChestActivity GDpQXGGuFLpS6FxsEXfu;

				// Token: 0x02000B08 RID: 2824
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static class Types
				{
					// Token: 0x0600873B RID: 34619 RVA: 0x0031836C File Offset: 0x0031656C
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000B09 RID: 2825
					public enum ChestEventType
					{
						// Token: 0x040031AF RID: 12719
						[OriginalName("DEPOSIT")]
						Deposit,
						// Token: 0x040031B0 RID: 12720
						[OriginalName("WITHDRAW")]
						Withdraw,
						// Token: 0x040031B1 RID: 12721
						[OriginalName("TRANSFER")]
						Transfer
					}
				}
			}

			// Token: 0x02000B0B RID: 2827
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class PaddockActivity : IMessage<GuildLogbookEntry.Types.PaddockActivity>, IMessage, IEquatable<GuildLogbookEntry.Types.PaddockActivity>, IDeepCloneable<GuildLogbookEntry.Types.PaddockActivity>, IBufferMessage
			{
				// Token: 0x170018F4 RID: 6388
				// (get) Token: 0x06008741 RID: 34625 RVA: 0x00309A34 File Offset: 0x00307C34
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<GuildLogbookEntry.Types.PaddockActivity> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170018F5 RID: 6389
				// (get) Token: 0x06008742 RID: 34626 RVA: 0x00309A44 File Offset: 0x00307C44
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

				// Token: 0x170018F6 RID: 6390
				// (get) Token: 0x06008743 RID: 34627 RVA: 0x00309A54 File Offset: 0x00307C54
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

				// Token: 0x06008744 RID: 34628 RVA: 0x00309A64 File Offset: 0x00307C64
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PaddockActivity()
				{
				}

				// Token: 0x06008745 RID: 34629 RVA: 0x00309A74 File Offset: 0x00307C74
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PaddockActivity(GuildLogbookEntry.Types.PaddockActivity other)
				{
				}

				// Token: 0x06008746 RID: 34630 RVA: 0x00309A84 File Offset: 0x00307C84
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GuildLogbookEntry.Types.PaddockActivity Clone()
				{
					return null;
				}

				// Token: 0x170018F7 RID: 6391
				// (get) Token: 0x06008747 RID: 34631 RVA: 0x00309A94 File Offset: 0x00307C94
				// (set) Token: 0x06008748 RID: 34632 RVA: 0x00309AA4 File Offset: 0x00307CA4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x170018F8 RID: 6392
				// (get) Token: 0x06008749 RID: 34633 RVA: 0x00309AB4 File Offset: 0x00307CB4
				// (set) Token: 0x0600874A RID: 34634 RVA: 0x00309AC4 File Offset: 0x00307CC4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public string PlayerName
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

				// Token: 0x170018F9 RID: 6393
				// (get) Token: 0x0600874B RID: 34635 RVA: 0x00309AD4 File Offset: 0x00307CD4
				// (set) Token: 0x0600874C RID: 34636 RVA: 0x00309AE4 File Offset: 0x00307CE4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public MapExtendedCoordinates PaddockCoordinates
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

				// Token: 0x170018FA RID: 6394
				// (get) Token: 0x0600874D RID: 34637 RVA: 0x00309AF4 File Offset: 0x00307CF4
				// (set) Token: 0x0600874E RID: 34638 RVA: 0x00309B04 File Offset: 0x00307D04
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public long FarmId
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

				// Token: 0x170018FB RID: 6395
				// (get) Token: 0x0600874F RID: 34639 RVA: 0x00309B14 File Offset: 0x00307D14
				// (set) Token: 0x06008750 RID: 34640 RVA: 0x00309B28 File Offset: 0x00307D28
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public GuildLogbookEntry.Types.PaddockActivity.Types.PaddockCommercialEventType PaddockCommercialEventType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (GuildLogbookEntry.Types.PaddockActivity.Types.PaddockCommercialEventType)null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x06008751 RID: 34641 RVA: 0x00309B38 File Offset: 0x00307D38
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008752 RID: 34642 RVA: 0x00309B48 File Offset: 0x00307D48
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GuildLogbookEntry.Types.PaddockActivity other)
				{
					return true;
				}

				// Token: 0x06008753 RID: 34643 RVA: 0x00309B58 File Offset: 0x00307D58
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008754 RID: 34644 RVA: 0x00309B68 File Offset: 0x00307D68
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008755 RID: 34645 RVA: 0x00309B78 File Offset: 0x00307D78
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008756 RID: 34646 RVA: 0x00309B88 File Offset: 0x00307D88
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008757 RID: 34647 RVA: 0x00309B98 File Offset: 0x00307D98
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008758 RID: 34648 RVA: 0x00309BA8 File Offset: 0x00307DA8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GuildLogbookEntry.Types.PaddockActivity other)
				{
				}

				// Token: 0x06008759 RID: 34649 RVA: 0x00309BB8 File Offset: 0x00307DB8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600875A RID: 34650 RVA: 0x00309BC8 File Offset: 0x00307DC8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600875B RID: 34651 RVA: 0x00309BD8 File Offset: 0x00307DD8
				[MethodImpl(MethodImplOptions.NoInlining)]
				static PaddockActivity()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							GuildLogbookEntry.Types.PaddockActivity._parser = new MessageParser<GuildLogbookEntry.Types.PaddockActivity>(() => null);
							num2 = 4;
							break;
						case 1:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 != 0)
							{
								num2 = 1;
							}
							break;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
							{
								num2 = 1;
							}
							break;
						case 4:
							return;
						}
					}
				}

				// Token: 0x0600875C RID: 34652 RVA: 0x00309CBC File Offset: 0x00307EBC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool DFoOcsG8mnLD7cqfKLkC()
				{
					return true;
				}

				// Token: 0x0600875D RID: 34653 RVA: 0x00309CC4 File Offset: 0x00307EC4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GuildLogbookEntry.Types.PaddockActivity BaFqxrG8AhJRpjA0VuWB()
				{
					return null;
				}

				// Token: 0x040031B4 RID: 12724
				private static readonly MessageParser<GuildLogbookEntry.Types.PaddockActivity> _parser;

				// Token: 0x040031B5 RID: 12725
				private UnknownFieldSet _unknownFields;

				// Token: 0x040031B6 RID: 12726
				public const int PlayerIdFieldNumber = 1;

				// Token: 0x040031B7 RID: 12727
				private long playerId_;

				// Token: 0x040031B8 RID: 12728
				public const int PlayerNameFieldNumber = 2;

				// Token: 0x040031B9 RID: 12729
				private string playerName_;

				// Token: 0x040031BA RID: 12730
				public const int PaddockCoordinatesFieldNumber = 3;

				// Token: 0x040031BB RID: 12731
				private MapExtendedCoordinates paddockCoordinates_;

				// Token: 0x040031BC RID: 12732
				public const int FarmIdFieldNumber = 4;

				// Token: 0x040031BD RID: 12733
				private long farmId_;

				// Token: 0x040031BE RID: 12734
				public const int PaddockCommercialEventTypeFieldNumber = 5;

				// Token: 0x040031BF RID: 12735
				private GuildLogbookEntry.Types.PaddockActivity.Types.PaddockCommercialEventType paddockCommercialEventType_;

				// Token: 0x040031C0 RID: 12736
				private static GuildLogbookEntry.Types.PaddockActivity TPtcpZG8n3Mi4ukRc5ZW;

				// Token: 0x02000B0C RID: 2828
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x0600875E RID: 34654 RVA: 0x0031847C File Offset: 0x0031667C
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000B0D RID: 2829
					public enum PaddockCommercialEventType
					{
						// Token: 0x040031C2 RID: 12738
						[OriginalName("BUY")]
						Buy,
						// Token: 0x040031C3 RID: 12739
						[OriginalName("PUT_ON_SELL")]
						PutOnSell,
						// Token: 0x040031C4 RID: 12740
						[OriginalName("SOLD")]
						Sold
					}
				}
			}

			// Token: 0x02000B0F RID: 2831
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class PlayerFlowActivity : IMessage<GuildLogbookEntry.Types.PlayerFlowActivity>, IMessage, IEquatable<GuildLogbookEntry.Types.PlayerFlowActivity>, IDeepCloneable<GuildLogbookEntry.Types.PlayerFlowActivity>, IBufferMessage
			{
				// Token: 0x170018FC RID: 6396
				// (get) Token: 0x06008764 RID: 34660 RVA: 0x00309CCC File Offset: 0x00307ECC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GuildLogbookEntry.Types.PlayerFlowActivity> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170018FD RID: 6397
				// (get) Token: 0x06008765 RID: 34661 RVA: 0x00309CDC File Offset: 0x00307EDC
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

				// Token: 0x170018FE RID: 6398
				// (get) Token: 0x06008766 RID: 34662 RVA: 0x00309CEC File Offset: 0x00307EEC
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

				// Token: 0x06008767 RID: 34663 RVA: 0x00309CFC File Offset: 0x00307EFC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PlayerFlowActivity()
				{
				}

				// Token: 0x06008768 RID: 34664 RVA: 0x00309D0C File Offset: 0x00307F0C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PlayerFlowActivity(GuildLogbookEntry.Types.PlayerFlowActivity other)
				{
				}

				// Token: 0x06008769 RID: 34665 RVA: 0x00309D1C File Offset: 0x00307F1C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GuildLogbookEntry.Types.PlayerFlowActivity Clone()
				{
					return null;
				}

				// Token: 0x170018FF RID: 6399
				// (get) Token: 0x0600876A RID: 34666 RVA: 0x00309D2C File Offset: 0x00307F2C
				// (set) Token: 0x0600876B RID: 34667 RVA: 0x00309D3C File Offset: 0x00307F3C
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

				// Token: 0x17001900 RID: 6400
				// (get) Token: 0x0600876C RID: 34668 RVA: 0x00309D4C File Offset: 0x00307F4C
				// (set) Token: 0x0600876D RID: 34669 RVA: 0x00309D5C File Offset: 0x00307F5C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string PlayerName
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

				// Token: 0x17001901 RID: 6401
				// (get) Token: 0x0600876E RID: 34670 RVA: 0x00309D6C File Offset: 0x00307F6C
				// (set) Token: 0x0600876F RID: 34671 RVA: 0x00309D80 File Offset: 0x00307F80
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public GuildLogbookEntry.Types.PlayerFlowActivity.Types.PlayerFlowEventType PlayerFlowEventType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (GuildLogbookEntry.Types.PlayerFlowActivity.Types.PlayerFlowEventType)null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x06008770 RID: 34672 RVA: 0x00309D90 File Offset: 0x00307F90
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008771 RID: 34673 RVA: 0x00309DA0 File Offset: 0x00307FA0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GuildLogbookEntry.Types.PlayerFlowActivity other)
				{
					return true;
				}

				// Token: 0x06008772 RID: 34674 RVA: 0x00309DB0 File Offset: 0x00307FB0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008773 RID: 34675 RVA: 0x00309DC0 File Offset: 0x00307FC0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008774 RID: 34676 RVA: 0x00309DD0 File Offset: 0x00307FD0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008775 RID: 34677 RVA: 0x00309DE0 File Offset: 0x00307FE0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008776 RID: 34678 RVA: 0x00309DF0 File Offset: 0x00307FF0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008777 RID: 34679 RVA: 0x00309E00 File Offset: 0x00308000
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GuildLogbookEntry.Types.PlayerFlowActivity other)
				{
				}

				// Token: 0x06008778 RID: 34680 RVA: 0x00309E10 File Offset: 0x00308010
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008779 RID: 34681 RVA: 0x00309E20 File Offset: 0x00308020
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600877A RID: 34682 RVA: 0x00309E30 File Offset: 0x00308030
				[MethodImpl(MethodImplOptions.NoInlining)]
				static PlayerFlowActivity()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							return;
						case 3:
							GuildLogbookEntry.Types.PlayerFlowActivity._parser = new MessageParser<GuildLogbookEntry.Types.PlayerFlowActivity>(() => null);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 != 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 3;
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 4;
					}
				}

				// Token: 0x0600877B RID: 34683 RVA: 0x00309EFC File Offset: 0x003080FC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool AZUTrqG8e4rlse6PYhKL()
				{
					return true;
				}

				// Token: 0x0600877C RID: 34684 RVA: 0x00309F04 File Offset: 0x00308104
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GuildLogbookEntry.Types.PlayerFlowActivity jMIP2LG83kcvNd8AOia8()
				{
					return null;
				}

				// Token: 0x040031C7 RID: 12743
				private static readonly MessageParser<GuildLogbookEntry.Types.PlayerFlowActivity> _parser;

				// Token: 0x040031C8 RID: 12744
				private UnknownFieldSet _unknownFields;

				// Token: 0x040031C9 RID: 12745
				public const int PlayerIdFieldNumber = 1;

				// Token: 0x040031CA RID: 12746
				private long playerId_;

				// Token: 0x040031CB RID: 12747
				public const int PlayerNameFieldNumber = 2;

				// Token: 0x040031CC RID: 12748
				private string playerName_;

				// Token: 0x040031CD RID: 12749
				public const int PlayerFlowEventTypeFieldNumber = 3;

				// Token: 0x040031CE RID: 12750
				private GuildLogbookEntry.Types.PlayerFlowActivity.Types.PlayerFlowEventType playerFlowEventType_;

				// Token: 0x040031CF RID: 12751
				private static GuildLogbookEntry.Types.PlayerFlowActivity rgqvy7G8BU13iEp0Hdx8;

				// Token: 0x02000B10 RID: 2832
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static class Types
				{
					// Token: 0x0600877D RID: 34685 RVA: 0x00318590 File Offset: 0x00316790
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000B11 RID: 2833
					public enum PlayerFlowEventType
					{
						// Token: 0x040031D1 RID: 12753
						[OriginalName("JOIN")]
						Join,
						// Token: 0x040031D2 RID: 12754
						[OriginalName("LEAVE")]
						Leave,
						// Token: 0x040031D3 RID: 12755
						[OriginalName("APPLY_REFUSED")]
						ApplyRefused
					}
				}
			}

			// Token: 0x02000B13 RID: 2835
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class LevelUpActivity : IMessage<GuildLogbookEntry.Types.LevelUpActivity>, IMessage, IEquatable<GuildLogbookEntry.Types.LevelUpActivity>, IDeepCloneable<GuildLogbookEntry.Types.LevelUpActivity>, IBufferMessage
			{
				// Token: 0x17001902 RID: 6402
				// (get) Token: 0x06008783 RID: 34691 RVA: 0x00309F0C File Offset: 0x0030810C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<GuildLogbookEntry.Types.LevelUpActivity> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001903 RID: 6403
				// (get) Token: 0x06008784 RID: 34692 RVA: 0x00309F1C File Offset: 0x0030811C
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

				// Token: 0x17001904 RID: 6404
				// (get) Token: 0x06008785 RID: 34693 RVA: 0x00309F2C File Offset: 0x0030812C
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

				// Token: 0x06008786 RID: 34694 RVA: 0x00309F3C File Offset: 0x0030813C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public LevelUpActivity()
				{
				}

				// Token: 0x06008787 RID: 34695 RVA: 0x00309F4C File Offset: 0x0030814C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public LevelUpActivity(GuildLogbookEntry.Types.LevelUpActivity other)
				{
				}

				// Token: 0x06008788 RID: 34696 RVA: 0x00309F5C File Offset: 0x0030815C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GuildLogbookEntry.Types.LevelUpActivity Clone()
				{
					return null;
				}

				// Token: 0x17001905 RID: 6405
				// (get) Token: 0x06008789 RID: 34697 RVA: 0x00309F6C File Offset: 0x0030816C
				// (set) Token: 0x0600878A RID: 34698 RVA: 0x00309F7C File Offset: 0x0030817C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int NewGuildLevel
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

				// Token: 0x0600878B RID: 34699 RVA: 0x00309F8C File Offset: 0x0030818C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600878C RID: 34700 RVA: 0x00309F9C File Offset: 0x0030819C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GuildLogbookEntry.Types.LevelUpActivity other)
				{
					return true;
				}

				// Token: 0x0600878D RID: 34701 RVA: 0x00309FAC File Offset: 0x003081AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600878E RID: 34702 RVA: 0x00309FBC File Offset: 0x003081BC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600878F RID: 34703 RVA: 0x00309FCC File Offset: 0x003081CC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06008790 RID: 34704 RVA: 0x00309FDC File Offset: 0x003081DC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06008791 RID: 34705 RVA: 0x00309FEC File Offset: 0x003081EC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06008792 RID: 34706 RVA: 0x00309FFC File Offset: 0x003081FC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GuildLogbookEntry.Types.LevelUpActivity other)
				{
				}

				// Token: 0x06008793 RID: 34707 RVA: 0x0030A00C File Offset: 0x0030820C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06008794 RID: 34708 RVA: 0x0030A01C File Offset: 0x0030821C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06008795 RID: 34709 RVA: 0x0030A02C File Offset: 0x0030822C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static LevelUpActivity()
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
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 != 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							continue;
						case 4:
							GuildLogbookEntry.Types.LevelUpActivity._parser = new MessageParser<GuildLogbookEntry.Types.LevelUpActivity>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x06008796 RID: 34710 RVA: 0x0030A110 File Offset: 0x00308310
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool TOgbrUG8OME0bJ1O8CRG()
				{
					return true;
				}

				// Token: 0x06008797 RID: 34711 RVA: 0x0030A118 File Offset: 0x00308318
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GuildLogbookEntry.Types.LevelUpActivity c2t9C7G8Jc4s528v2Y3W()
				{
					return null;
				}

				// Token: 0x040031D6 RID: 12758
				private static readonly MessageParser<GuildLogbookEntry.Types.LevelUpActivity> _parser;

				// Token: 0x040031D7 RID: 12759
				private UnknownFieldSet _unknownFields;

				// Token: 0x040031D8 RID: 12760
				public const int NewGuildLevelFieldNumber = 1;

				// Token: 0x040031D9 RID: 12761
				private int newGuildLevel_;

				// Token: 0x040031DA RID: 12762
				private static GuildLogbookEntry.Types.LevelUpActivity G0EAcVG8RIxnmn7AUYtQ;
			}

			// Token: 0x02000B15 RID: 2837
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class UnlockNewTabActivity : IMessage<GuildLogbookEntry.Types.UnlockNewTabActivity>, IMessage, IEquatable<GuildLogbookEntry.Types.UnlockNewTabActivity>, IDeepCloneable<GuildLogbookEntry.Types.UnlockNewTabActivity>, IBufferMessage
			{
				// Token: 0x17001906 RID: 6406
				// (get) Token: 0x0600879D RID: 34717 RVA: 0x0030A120 File Offset: 0x00308320
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GuildLogbookEntry.Types.UnlockNewTabActivity> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001907 RID: 6407
				// (get) Token: 0x0600879E RID: 34718 RVA: 0x0030A130 File Offset: 0x00308330
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

				// Token: 0x17001908 RID: 6408
				// (get) Token: 0x0600879F RID: 34719 RVA: 0x0030A140 File Offset: 0x00308340
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

				// Token: 0x060087A0 RID: 34720 RVA: 0x0030A150 File Offset: 0x00308350
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public UnlockNewTabActivity()
				{
				}

				// Token: 0x060087A1 RID: 34721 RVA: 0x0030A160 File Offset: 0x00308360
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public UnlockNewTabActivity(GuildLogbookEntry.Types.UnlockNewTabActivity other)
				{
				}

				// Token: 0x060087A2 RID: 34722 RVA: 0x0030A170 File Offset: 0x00308370
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GuildLogbookEntry.Types.UnlockNewTabActivity Clone()
				{
					return null;
				}

				// Token: 0x060087A3 RID: 34723 RVA: 0x0030A180 File Offset: 0x00308380
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060087A4 RID: 34724 RVA: 0x0030A190 File Offset: 0x00308390
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GuildLogbookEntry.Types.UnlockNewTabActivity other)
				{
					return true;
				}

				// Token: 0x060087A5 RID: 34725 RVA: 0x0030A1A0 File Offset: 0x003083A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060087A6 RID: 34726 RVA: 0x0030A1B0 File Offset: 0x003083B0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060087A7 RID: 34727 RVA: 0x0030A1C0 File Offset: 0x003083C0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060087A8 RID: 34728 RVA: 0x0030A1D0 File Offset: 0x003083D0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060087A9 RID: 34729 RVA: 0x0030A1E0 File Offset: 0x003083E0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060087AA RID: 34730 RVA: 0x0030A1F0 File Offset: 0x003083F0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GuildLogbookEntry.Types.UnlockNewTabActivity other)
				{
				}

				// Token: 0x060087AB RID: 34731 RVA: 0x0030A200 File Offset: 0x00308400
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060087AC RID: 34732 RVA: 0x0030A210 File Offset: 0x00308410
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060087AD RID: 34733 RVA: 0x0030A220 File Offset: 0x00308420
				[MethodImpl(MethodImplOptions.NoInlining)]
				static UnlockNewTabActivity()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							return;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 4;
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						GuildLogbookEntry.Types.UnlockNewTabActivity._parser = new MessageParser<GuildLogbookEntry.Types.UnlockNewTabActivity>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
						{
							num2 = 0;
						}
					}
				}

				// Token: 0x060087AE RID: 34734 RVA: 0x0030A304 File Offset: 0x00308504
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool N8n5MxG8geNay6Cx1qFb()
				{
					return true;
				}

				// Token: 0x060087AF RID: 34735 RVA: 0x0030A30C File Offset: 0x0030850C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GuildLogbookEntry.Types.UnlockNewTabActivity sqRPI8G8sPgOX9mVio1E()
				{
					return null;
				}

				// Token: 0x040031DD RID: 12765
				private static readonly MessageParser<GuildLogbookEntry.Types.UnlockNewTabActivity> _parser;

				// Token: 0x040031DE RID: 12766
				private UnknownFieldSet _unknownFields;

				// Token: 0x040031DF RID: 12767
				private static GuildLogbookEntry.Types.UnlockNewTabActivity yyHL5xG8GJfxRev9YLhI;
			}

			// Token: 0x02000B17 RID: 2839
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class RankActivity : IMessage<GuildLogbookEntry.Types.RankActivity>, IMessage, IEquatable<GuildLogbookEntry.Types.RankActivity>, IDeepCloneable<GuildLogbookEntry.Types.RankActivity>, IBufferMessage
			{
				// Token: 0x17001909 RID: 6409
				// (get) Token: 0x060087B5 RID: 34741 RVA: 0x0030A314 File Offset: 0x00308514
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GuildLogbookEntry.Types.RankActivity> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700190A RID: 6410
				// (get) Token: 0x060087B6 RID: 34742 RVA: 0x0030A324 File Offset: 0x00308524
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

				// Token: 0x1700190B RID: 6411
				// (get) Token: 0x060087B7 RID: 34743 RVA: 0x0030A334 File Offset: 0x00308534
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

				// Token: 0x060087B8 RID: 34744 RVA: 0x0030A344 File Offset: 0x00308544
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public RankActivity()
				{
				}

				// Token: 0x060087B9 RID: 34745 RVA: 0x0030A354 File Offset: 0x00308554
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public RankActivity(GuildLogbookEntry.Types.RankActivity other)
				{
				}

				// Token: 0x060087BA RID: 34746 RVA: 0x0030A364 File Offset: 0x00308564
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GuildLogbookEntry.Types.RankActivity Clone()
				{
					return null;
				}

				// Token: 0x1700190C RID: 6412
				// (get) Token: 0x060087BB RID: 34747 RVA: 0x0030A374 File Offset: 0x00308574
				// (set) Token: 0x060087BC RID: 34748 RVA: 0x0030A388 File Offset: 0x00308588
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public GuildLogbookEntry.Types.RankActivity.Types.RankActivityType RankActivityType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (GuildLogbookEntry.Types.RankActivity.Types.RankActivityType)null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x1700190D RID: 6413
				// (get) Token: 0x060087BD RID: 34749 RVA: 0x0030A398 File Offset: 0x00308598
				// (set) Token: 0x060087BE RID: 34750 RVA: 0x0030A3A8 File Offset: 0x003085A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RankInformation RankInformation
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

				// Token: 0x060087BF RID: 34751 RVA: 0x0030A3B8 File Offset: 0x003085B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060087C0 RID: 34752 RVA: 0x0030A3C8 File Offset: 0x003085C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GuildLogbookEntry.Types.RankActivity other)
				{
					return true;
				}

				// Token: 0x060087C1 RID: 34753 RVA: 0x0030A3D8 File Offset: 0x003085D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060087C2 RID: 34754 RVA: 0x0030A3E8 File Offset: 0x003085E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060087C3 RID: 34755 RVA: 0x0030A3F8 File Offset: 0x003085F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060087C4 RID: 34756 RVA: 0x0030A408 File Offset: 0x00308608
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060087C5 RID: 34757 RVA: 0x0030A418 File Offset: 0x00308618
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060087C6 RID: 34758 RVA: 0x0030A428 File Offset: 0x00308628
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GuildLogbookEntry.Types.RankActivity other)
				{
				}

				// Token: 0x060087C7 RID: 34759 RVA: 0x0030A438 File Offset: 0x00308638
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060087C8 RID: 34760 RVA: 0x0030A448 File Offset: 0x00308648
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060087C9 RID: 34761 RVA: 0x0030A458 File Offset: 0x00308658
				[MethodImpl(MethodImplOptions.NoInlining)]
				static RankActivity()
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
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 2:
								return;
							case 3:
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 4;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							case 4:
								GuildLogbookEntry.Types.RankActivity._parser = new MessageParser<GuildLogbookEntry.Types.RankActivity>(() => null);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 == 0)
								{
									num2 = 2;
									continue;
								}
								continue;
							}
							break;
						}
						IL_C1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num = 3;
						continue;
						goto IL_C1;
					}
				}

				// Token: 0x060087CA RID: 34762 RVA: 0x0030A540 File Offset: 0x00308740
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool TrFFVqG89WLkyWnAXAYQ()
				{
					return true;
				}

				// Token: 0x060087CB RID: 34763 RVA: 0x0030A548 File Offset: 0x00308748
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GuildLogbookEntry.Types.RankActivity WVp5iBG82u0UfQJqb9wY()
				{
					return null;
				}

				// Token: 0x040031E2 RID: 12770
				private static readonly MessageParser<GuildLogbookEntry.Types.RankActivity> _parser;

				// Token: 0x040031E3 RID: 12771
				private UnknownFieldSet _unknownFields;

				// Token: 0x040031E4 RID: 12772
				public const int RankActivityTypeFieldNumber = 1;

				// Token: 0x040031E5 RID: 12773
				private GuildLogbookEntry.Types.RankActivity.Types.RankActivityType rankActivityType_;

				// Token: 0x040031E6 RID: 12774
				public const int RankInformationFieldNumber = 2;

				// Token: 0x040031E7 RID: 12775
				private RankInformation rankInformation_;

				// Token: 0x040031E8 RID: 12776
				internal static GuildLogbookEntry.Types.RankActivity houucTG8dbKADC0R7QkQ;

				// Token: 0x02000B18 RID: 2840
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static class Types
				{
					// Token: 0x060087CC RID: 34764 RVA: 0x003188A8 File Offset: 0x00316AA8
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000B19 RID: 2841
					public enum RankActivityType
					{
						// Token: 0x040031EA RID: 12778
						[OriginalName("CREATION")]
						Creation,
						// Token: 0x040031EB RID: 12779
						[OriginalName("UPDATE")]
						Update,
						// Token: 0x040031EC RID: 12780
						[OriginalName("DELETE")]
						Delete
					}
				}
			}

			// Token: 0x02000B1B RID: 2843
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class PlayerRankUpdateActivity : IMessage<GuildLogbookEntry.Types.PlayerRankUpdateActivity>, IMessage, IEquatable<GuildLogbookEntry.Types.PlayerRankUpdateActivity>, IDeepCloneable<GuildLogbookEntry.Types.PlayerRankUpdateActivity>, IBufferMessage
			{
				// Token: 0x1700190E RID: 6414
				// (get) Token: 0x060087D2 RID: 34770 RVA: 0x0030A550 File Offset: 0x00308750
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GuildLogbookEntry.Types.PlayerRankUpdateActivity> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700190F RID: 6415
				// (get) Token: 0x060087D3 RID: 34771 RVA: 0x0030A560 File Offset: 0x00308760
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

				// Token: 0x17001910 RID: 6416
				// (get) Token: 0x060087D4 RID: 34772 RVA: 0x0030A570 File Offset: 0x00308770
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

				// Token: 0x060087D5 RID: 34773 RVA: 0x0030A580 File Offset: 0x00308780
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PlayerRankUpdateActivity()
				{
				}

				// Token: 0x060087D6 RID: 34774 RVA: 0x0030A590 File Offset: 0x00308790
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PlayerRankUpdateActivity(GuildLogbookEntry.Types.PlayerRankUpdateActivity other)
				{
				}

				// Token: 0x060087D7 RID: 34775 RVA: 0x0030A5A0 File Offset: 0x003087A0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GuildLogbookEntry.Types.PlayerRankUpdateActivity Clone()
				{
					return null;
				}

				// Token: 0x17001911 RID: 6417
				// (get) Token: 0x060087D8 RID: 34776 RVA: 0x0030A5B0 File Offset: 0x003087B0
				// (set) Token: 0x060087D9 RID: 34777 RVA: 0x0030A5C0 File Offset: 0x003087C0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public RankInformation RankInformation
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

				// Token: 0x17001912 RID: 6418
				// (get) Token: 0x060087DA RID: 34778 RVA: 0x0030A5D0 File Offset: 0x003087D0
				// (set) Token: 0x060087DB RID: 34779 RVA: 0x0030A5E0 File Offset: 0x003087E0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long SourcePlayerId
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

				// Token: 0x17001913 RID: 6419
				// (get) Token: 0x060087DC RID: 34780 RVA: 0x0030A5F0 File Offset: 0x003087F0
				// (set) Token: 0x060087DD RID: 34781 RVA: 0x0030A600 File Offset: 0x00308800
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public long TargetPlayerId
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

				// Token: 0x17001914 RID: 6420
				// (get) Token: 0x060087DE RID: 34782 RVA: 0x0030A610 File Offset: 0x00308810
				// (set) Token: 0x060087DF RID: 34783 RVA: 0x0030A620 File Offset: 0x00308820
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public string SourcePlayerName
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

				// Token: 0x17001915 RID: 6421
				// (get) Token: 0x060087E0 RID: 34784 RVA: 0x0030A630 File Offset: 0x00308830
				// (set) Token: 0x060087E1 RID: 34785 RVA: 0x0030A640 File Offset: 0x00308840
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public string TargetPlayerName
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

				// Token: 0x060087E2 RID: 34786 RVA: 0x0030A650 File Offset: 0x00308850
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060087E3 RID: 34787 RVA: 0x0030A660 File Offset: 0x00308860
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GuildLogbookEntry.Types.PlayerRankUpdateActivity other)
				{
					return true;
				}

				// Token: 0x060087E4 RID: 34788 RVA: 0x0030A670 File Offset: 0x00308870
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060087E5 RID: 34789 RVA: 0x0030A680 File Offset: 0x00308880
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060087E6 RID: 34790 RVA: 0x0030A690 File Offset: 0x00308890
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060087E7 RID: 34791 RVA: 0x0030A6A0 File Offset: 0x003088A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060087E8 RID: 34792 RVA: 0x0030A6B0 File Offset: 0x003088B0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060087E9 RID: 34793 RVA: 0x0030A6C0 File Offset: 0x003088C0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GuildLogbookEntry.Types.PlayerRankUpdateActivity other)
				{
				}

				// Token: 0x060087EA RID: 34794 RVA: 0x0030A6D0 File Offset: 0x003088D0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060087EB RID: 34795 RVA: 0x0030A6E0 File Offset: 0x003088E0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060087EC RID: 34796 RVA: 0x0030A6F0 File Offset: 0x003088F0
				[MethodImpl(MethodImplOptions.NoInlining)]
				static PlayerRankUpdateActivity()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							return;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						GuildLogbookEntry.Types.PlayerRankUpdateActivity._parser = new MessageParser<GuildLogbookEntry.Types.PlayerRankUpdateActivity>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x060087ED RID: 34797 RVA: 0x0030A7E8 File Offset: 0x003089E8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool XP8LxLG8XyaPFlJ9csaS()
				{
					return true;
				}

				// Token: 0x060087EE RID: 34798 RVA: 0x0030A7F0 File Offset: 0x003089F0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GuildLogbookEntry.Types.PlayerRankUpdateActivity LEcXnSG8NNoUd2TNvV5H()
				{
					return null;
				}

				// Token: 0x040031EF RID: 12783
				private static readonly MessageParser<GuildLogbookEntry.Types.PlayerRankUpdateActivity> _parser;

				// Token: 0x040031F0 RID: 12784
				private UnknownFieldSet _unknownFields;

				// Token: 0x040031F1 RID: 12785
				public const int RankInformationFieldNumber = 1;

				// Token: 0x040031F2 RID: 12786
				private RankInformation rankInformation_;

				// Token: 0x040031F3 RID: 12787
				public const int SourcePlayerIdFieldNumber = 2;

				// Token: 0x040031F4 RID: 12788
				private long sourcePlayerId_;

				// Token: 0x040031F5 RID: 12789
				public const int TargetPlayerIdFieldNumber = 3;

				// Token: 0x040031F6 RID: 12790
				private long targetPlayerId_;

				// Token: 0x040031F7 RID: 12791
				public const int SourcePlayerNameFieldNumber = 4;

				// Token: 0x040031F8 RID: 12792
				private string sourcePlayerName_;

				// Token: 0x040031F9 RID: 12793
				public const int TargetPlayerNameFieldNumber = 5;

				// Token: 0x040031FA RID: 12794
				private string targetPlayerName_;

				// Token: 0x040031FB RID: 12795
				private static GuildLogbookEntry.Types.PlayerRankUpdateActivity FCmx8fG8EbHKbemx55rR;
			}
		}
	}
}
