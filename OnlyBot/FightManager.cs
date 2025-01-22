using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Newtonsoft.Json;

namespace OnlyBot
{
	// Token: 0x02000E70 RID: 3696
	[Nullable(0)]
	[NullableContext(1)]
	internal class FightManager
	{
		// Token: 0x0600B0B6 RID: 45238 RVA: 0x002A1E6C File Offset: 0x002A006C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetCombat(bool isInCombat, int pid)
		{
		}

		// Token: 0x0600B0B7 RID: 45239 RVA: 0x002A1E7C File Offset: 0x002A007C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsInCombat(int pid)
		{
			return true;
		}

		// Token: 0x0600B0B8 RID: 45240 RVA: 0x002A1E8C File Offset: 0x002A008C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ClearCombatState(int pid)
		{
		}

		// Token: 0x0600B0B9 RID: 45241 RVA: 0x002A1E9C File Offset: 0x002A009C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<int> GetDeadEnemies(int pid)
		{
			return null;
		}

		// Token: 0x0600B0BA RID: 45242 RVA: 0x002A1EAC File Offset: 0x002A00AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ClearDeadEnemies(int pid)
		{
		}

		// Token: 0x0600B0BB RID: 45243 RVA: 0x002A1EBC File Offset: 0x002A00BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveEnemyFromChallengers(int pid, int enemyId)
		{
		}

		// Token: 0x0600B0BC RID: 45244 RVA: 0x002A1ECC File Offset: 0x002A00CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HandleKillStatistics(int pid, object jsonMessage)
		{
		}

		// Token: 0x0600B0BD RID: 45245 RVA: 0x002A1EF8 File Offset: 0x002A00F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UpdateCharacterTurnFromMessage(int pid, object jsonMessage)
		{
		}

		// Token: 0x0600B0BE RID: 45246 RVA: 0x002A1F24 File Offset: 0x002A0124
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsMyTurn(int pid, object myCharacterId)
		{
			return true;
		}

		// Token: 0x0600B0BF RID: 45247 RVA: 0x002A1F34 File Offset: 0x002A0134
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetCharacterTurn(int pid)
		{
			return null;
		}

		// Token: 0x0600B0C0 RID: 45248 RVA: 0x002A1F44 File Offset: 0x002A0144
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleFightPlacementPossiblePositionsEvent(string jsonData, int pid)
		{
		}

		// Token: 0x0600B0C1 RID: 45249 RVA: 0x002A1F54 File Offset: 0x002A0154
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleFightSynchronizeEvent(string jsonData, int pid)
		{
		}

		// Token: 0x0600B0C2 RID: 45250 RVA: 0x002A1F80 File Offset: 0x002A0180
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int? GetRoundNumber(int pid)
		{
			return null;
		}

		// Token: 0x0600B0C3 RID: 45251 RVA: 0x002A1F90 File Offset: 0x002A0190
		[MethodImpl(MethodImplOptions.NoInlining)]
		[return: TupleElementNames(new string[]
		{
			"challengersPositions",
			"defendersPositions"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public ValueTuple<List<int>, List<int>>? GetFightPositions(int pid)
		{
			return null;
		}

		// Token: 0x0600B0C4 RID: 45252 RVA: 0x002A1FA0 File Offset: 0x002A01A0
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightManager.FightStartingData GetFightStartingData(int pid)
		{
			return null;
		}

		// Token: 0x0600B0C5 RID: 45253 RVA: 0x002A1FB0 File Offset: 0x002A01B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, FightManager.FighterData> GetFightersByPid(int pid)
		{
			return null;
		}

		// Token: 0x0600B0C6 RID: 45254 RVA: 0x002A1FC0 File Offset: 0x002A01C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		[return: Nullable(2)]
		public FightManager.FighterData GetFighterByActorId(int pid, string actorId)
		{
			return null;
		}

		// Token: 0x0600B0C7 RID: 45255 RVA: 0x002A1FD0 File Offset: 0x002A01D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleMapMovementEvent(string jsonData, int pid)
		{
		}

		// Token: 0x0600B0C8 RID: 45256 RVA: 0x002A1FE0 File Offset: 0x002A01E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateFighterPositionWithHistory(int pid, string actorId, List<int> cells)
		{
		}

		// Token: 0x0600B0C9 RID: 45257 RVA: 0x002A2000 File Offset: 0x002A0200
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DeleteLastPos(int pid, int targetCellId)
		{
		}

		// Token: 0x0600B0CA RID: 45258 RVA: 0x002A202C File Offset: 0x002A022C
		[MethodImpl(MethodImplOptions.NoInlining)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, FightManager.MapMovementData> GetMovementsByPid(int pid)
		{
			return null;
		}

		// Token: 0x0600B0CB RID: 45259 RVA: 0x002A203C File Offset: 0x002A023C
		[MethodImpl(MethodImplOptions.NoInlining)]
		[return: Nullable(2)]
		public FightManager.MapMovementData GetMovementByCharacterId(int pid, string characterId)
		{
			return null;
		}

		// Token: 0x0600B0CC RID: 45260 RVA: 0x002A204C File Offset: 0x002A024C
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearMovements(int pid, string characterId = null)
		{
		}

		// Token: 0x0600B0CD RID: 45261 RVA: 0x002A205C File Offset: 0x002A025C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleFightStartingEvent(string jsonData, int pid)
		{
		}

		// Token: 0x0600B0CE RID: 45262 RVA: 0x002A206C File Offset: 0x002A026C
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[return: TupleElementNames(new string[]
		{
			"playerCellId",
			"closestMonsterCellId"
		})]
		public ValueTuple<int?, int?> GetClosestMonsterAndPlayerCell(int pid, [Nullable(1)] string playerActorId)
		{
			return null;
		}

		// Token: 0x0600B0CF RID: 45263 RVA: 0x002A208C File Offset: 0x002A028C
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetPlayerActorId(int pid)
		{
			return null;
		}

		// Token: 0x0600B0D0 RID: 45264 RVA: 0x002A20D0 File Offset: 0x002A02D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ClearFightPositions(int pid)
		{
		}

		// Token: 0x0600B0D1 RID: 45265 RVA: 0x002A20E0 File Offset: 0x002A02E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleRoundNumberEvent(string jsonData, int pid)
		{
		}

		// Token: 0x0600B0D2 RID: 45266 RVA: 0x002A210C File Offset: 0x002A030C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ClearFightSynchronizeData(int? pid = null)
		{
		}

		// Token: 0x0600B0D3 RID: 45267 RVA: 0x002A211C File Offset: 0x002A031C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightManager()
		{
		}

		// Token: 0x0600B0D4 RID: 45268 RVA: 0x002A212C File Offset: 0x002A032C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightManager()
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
					case 1:
						FightManager.fightSynchronizeData = new Dictionary<int, Dictionary<string, FightManager.FighterData>>();
						num2 = 8;
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 7;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 3:
						goto IL_CB;
					case 4:
						FightManager.fightPositions = new Dictionary<int, ValueTuple<List<int>, List<int>>>();
						num2 = 9;
						continue;
					case 5:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 6:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 5;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 7:
						FightManager.combatStates = new Dictionary<int, bool>();
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 8:
						FightManager.roundNumbers = new Dictionary<int, int>();
						num2 = 4;
						continue;
					case 9:
						FightManager.fightStartingData = new Dictionary<int, FightManager.FightStartingData>();
						num2 = 10;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 10:
						FightManager.mapMovements = new Dictionary<int, Dictionary<string, FightManager.MapMovementData>>();
						num2 = 3;
						continue;
					case 11:
						FightManager.ennemisMorts = new Dictionary<int, HashSet<int>>();
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_CB:
				FightManager.currentCharacterTurn = new Dictionary<int, string>();
				num = 11;
			}
		}

		// Token: 0x0600B0D5 RID: 45269 RVA: 0x002A22E8 File Offset: 0x002A04E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool v6PFj7JviiZahdR4JFeb()
		{
			return true;
		}

		// Token: 0x0600B0D6 RID: 45270 RVA: 0x002A22F0 File Offset: 0x002A04F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightManager IXPY21JvPbTqU5DSId2W()
		{
			return null;
		}

		// Token: 0x04004163 RID: 16739
		private static readonly Dictionary<int, bool> combatStates;

		// Token: 0x04004164 RID: 16740
		private static readonly Dictionary<int, Dictionary<string, FightManager.FighterData>> fightSynchronizeData;

		// Token: 0x04004165 RID: 16741
		private static readonly Dictionary<int, int> roundNumbers;

		// Token: 0x04004166 RID: 16742
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		[TupleElementNames(new string[]
		{
			"challengersPositions",
			"defendersPositions"
		})]
		private static readonly Dictionary<int, ValueTuple<List<int>, List<int>>> fightPositions;

		// Token: 0x04004167 RID: 16743
		private static readonly Dictionary<int, FightManager.FightStartingData> fightStartingData;

		// Token: 0x04004168 RID: 16744
		private static readonly Dictionary<int, Dictionary<string, FightManager.MapMovementData>> mapMovements;

		// Token: 0x04004169 RID: 16745
		private static readonly Dictionary<int, string> currentCharacterTurn;

		// Token: 0x0400416A RID: 16746
		private static readonly Dictionary<int, HashSet<int>> ennemisMorts;

		// Token: 0x0400416B RID: 16747
		private static object jY7XGQJvbSpSrP3xXXg0;

		// Token: 0x02000E71 RID: 3697
		[Nullable(0)]
		public class FightSynchronizeEvent
		{
			// Token: 0x170020A6 RID: 8358
			// (get) Token: 0x0600B0D7 RID: 45271 RVA: 0x002F5220 File Offset: 0x002F3420
			// (set) Token: 0x0600B0D8 RID: 45272 RVA: 0x002F5228 File Offset: 0x002F3428
			[JsonProperty("fighters")]
			public List<FightManager.Fighter> Fighters
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B0D9 RID: 45273 RVA: 0x002F5230 File Offset: 0x002F3430
			[MethodImpl(MethodImplOptions.NoInlining)]
			public FightSynchronizeEvent()
			{
			}

			// Token: 0x0600B0DA RID: 45274 RVA: 0x002F5240 File Offset: 0x002F3440
			[MethodImpl(MethodImplOptions.NoInlining)]
			static FightSynchronizeEvent()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B0DB RID: 45275 RVA: 0x002F5254 File Offset: 0x002F3454
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool U6BXc9GwRNpHePaUux81()
			{
				return true;
			}

			// Token: 0x0600B0DC RID: 45276 RVA: 0x002F525C File Offset: 0x002F345C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.FightSynchronizeEvent AgIMCXGwOLheH6mcRn7Q()
			{
				return null;
			}

			// Token: 0x0400416D RID: 16749
			internal static object E20RfPGw33Xja2LlsVxA;
		}

		// Token: 0x02000E72 RID: 3698
		[Nullable(0)]
		public class Fighter
		{
			// Token: 0x170020A7 RID: 8359
			// (get) Token: 0x0600B0DD RID: 45277 RVA: 0x002F5264 File Offset: 0x002F3464
			// (set) Token: 0x0600B0DE RID: 45278 RVA: 0x002F526C File Offset: 0x002F346C
			[JsonProperty("actorId")]
			public string ActorId
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020A8 RID: 8360
			// (get) Token: 0x0600B0DF RID: 45279 RVA: 0x002F527C File Offset: 0x002F347C
			// (set) Token: 0x0600B0E0 RID: 45280 RVA: 0x002F5284 File Offset: 0x002F3484
			[JsonProperty("disposition")]
			public FightManager.Disposition Disposition
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020A9 RID: 8361
			// (get) Token: 0x0600B0E1 RID: 45281 RVA: 0x002F5294 File Offset: 0x002F3494
			// (set) Token: 0x0600B0E2 RID: 45282 RVA: 0x002F529C File Offset: 0x002F349C
			[JsonProperty("actorInformation")]
			public FightManager.ActorInformation ActorInformation
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B0E3 RID: 45283 RVA: 0x002F52AC File Offset: 0x002F34AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Fighter()
			{
			}

			// Token: 0x0600B0E4 RID: 45284 RVA: 0x002F52BC File Offset: 0x002F34BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Fighter()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B0E5 RID: 45285 RVA: 0x002F52D0 File Offset: 0x002F34D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool uspw8BGwG2bPsjhTGxRr()
			{
				return true;
			}

			// Token: 0x0600B0E6 RID: 45286 RVA: 0x002F52D8 File Offset: 0x002F34D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.Fighter hosTubGwgqDJlguRRAwj()
			{
				return null;
			}

			// Token: 0x04004171 RID: 16753
			internal static object mxB7f2GwJxTtRY1fA12c;
		}

		// Token: 0x02000E73 RID: 3699
		[Nullable(0)]
		public class Disposition
		{
			// Token: 0x170020AA RID: 8362
			// (get) Token: 0x0600B0E7 RID: 45287 RVA: 0x002F52E0 File Offset: 0x002F34E0
			// (set) Token: 0x0600B0E8 RID: 45288 RVA: 0x002F52E8 File Offset: 0x002F34E8
			[JsonProperty("cellId")]
			public int CellId
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020AB RID: 8363
			// (get) Token: 0x0600B0E9 RID: 45289 RVA: 0x002F52F8 File Offset: 0x002F34F8
			// (set) Token: 0x0600B0EA RID: 45290 RVA: 0x002F5300 File Offset: 0x002F3500
			[JsonProperty("direction")]
			public string Direction
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B0EB RID: 45291 RVA: 0x002F5310 File Offset: 0x002F3510
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Disposition()
			{
			}

			// Token: 0x0600B0EC RID: 45292 RVA: 0x002F5320 File Offset: 0x002F3520
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Disposition()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B0ED RID: 45293 RVA: 0x002F5334 File Offset: 0x002F3534
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool L8N8J9Gwdwc4ZYwo1vIG()
			{
				return true;
			}

			// Token: 0x0600B0EE RID: 45294 RVA: 0x002F533C File Offset: 0x002F353C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.Disposition wBsa3lGw9I4iyY8yerBC()
			{
				return null;
			}

			// Token: 0x04004174 RID: 16756
			internal static object BcmQ2mGwsuMPDtSrx5F2;
		}

		// Token: 0x02000E74 RID: 3700
		[NullableContext(0)]
		public class RoundNumberEvent
		{
			// Token: 0x170020AC RID: 8364
			// (get) Token: 0x0600B0EF RID: 45295 RVA: 0x002F5344 File Offset: 0x002F3544
			// (set) Token: 0x0600B0F0 RID: 45296 RVA: 0x002F534C File Offset: 0x002F354C
			[JsonProperty("roundNumber")]
			public int RoundNumber
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B0F1 RID: 45297 RVA: 0x002F535C File Offset: 0x002F355C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public RoundNumberEvent()
			{
			}

			// Token: 0x0600B0F2 RID: 45298 RVA: 0x002F536C File Offset: 0x002F356C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static RoundNumberEvent()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B0F3 RID: 45299 RVA: 0x002F5380 File Offset: 0x002F3580
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool jSPsUXGwEBXEWtmrbZww()
			{
				return true;
			}

			// Token: 0x0600B0F4 RID: 45300 RVA: 0x002F5388 File Offset: 0x002F3588
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.RoundNumberEvent KDiD4kGwXt4ST64aKOoA()
			{
				return null;
			}

			// Token: 0x04004176 RID: 16758
			internal static object aRPhDlGw2YV2tI4sCLlf;
		}

		// Token: 0x02000E75 RID: 3701
		[Nullable(0)]
		public class ActorInformation
		{
			// Token: 0x170020AD RID: 8365
			// (get) Token: 0x0600B0F5 RID: 45301 RVA: 0x002F5390 File Offset: 0x002F3590
			// (set) Token: 0x0600B0F6 RID: 45302 RVA: 0x002F5398 File Offset: 0x002F3598
			[JsonProperty("look")]
			public FightManager.Look Look
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020AE RID: 8366
			// (get) Token: 0x0600B0F7 RID: 45303 RVA: 0x002F53A8 File Offset: 0x002F35A8
			// (set) Token: 0x0600B0F8 RID: 45304 RVA: 0x002F53B0 File Offset: 0x002F35B0
			[JsonProperty("fighter")]
			public FightManager.FighterDetails FighterDetails
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B0F9 RID: 45305 RVA: 0x002F53C0 File Offset: 0x002F35C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public ActorInformation()
			{
			}

			// Token: 0x0600B0FA RID: 45306 RVA: 0x002F53D0 File Offset: 0x002F35D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static ActorInformation()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B0FB RID: 45307 RVA: 0x002F53E4 File Offset: 0x002F35E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool eTsZ2WGwxq5INqBs8Cq1()
			{
				return true;
			}

			// Token: 0x0600B0FC RID: 45308 RVA: 0x002F53EC File Offset: 0x002F35EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.ActorInformation dr8xORGw4Pl7P55Jp5qg()
			{
				return null;
			}

			// Token: 0x04004179 RID: 16761
			internal static object D8min8GwN4GZN0Xd63Jb;
		}

		// Token: 0x02000E76 RID: 3702
		[Nullable(0)]
		public class Look
		{
			// Token: 0x170020AF RID: 8367
			// (get) Token: 0x0600B0FD RID: 45309 RVA: 0x002F53F4 File Offset: 0x002F35F4
			// (set) Token: 0x0600B0FE RID: 45310 RVA: 0x002F53FC File Offset: 0x002F35FC
			[JsonProperty("bonesId")]
			public int BonesId
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020B0 RID: 8368
			// (get) Token: 0x0600B0FF RID: 45311 RVA: 0x002F540C File Offset: 0x002F360C
			// (set) Token: 0x0600B100 RID: 45312 RVA: 0x002F5414 File Offset: 0x002F3614
			[JsonProperty("skins")]
			public List<int> Skins
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020B1 RID: 8369
			// (get) Token: 0x0600B101 RID: 45313 RVA: 0x002F541C File Offset: 0x002F361C
			// (set) Token: 0x0600B102 RID: 45314 RVA: 0x002F5424 File Offset: 0x002F3624
			[JsonProperty("indexedColors")]
			public List<int> IndexedColors
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020B2 RID: 8370
			// (get) Token: 0x0600B103 RID: 45315 RVA: 0x002F542C File Offset: 0x002F362C
			// (set) Token: 0x0600B104 RID: 45316 RVA: 0x002F5434 File Offset: 0x002F3634
			[JsonProperty("scales")]
			public List<int> Scales
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B105 RID: 45317 RVA: 0x002F543C File Offset: 0x002F363C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Look()
			{
			}

			// Token: 0x0600B106 RID: 45318 RVA: 0x002F544C File Offset: 0x002F364C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Look()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B107 RID: 45319 RVA: 0x002F5460 File Offset: 0x002F3660
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool URitycGwKMiFDIKVpfrb()
			{
				return true;
			}

			// Token: 0x0600B108 RID: 45320 RVA: 0x002F5468 File Offset: 0x002F3668
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.Look cNyqQMGwI2wd5Nsrp0al()
			{
				return null;
			}

			// Token: 0x0400417E RID: 16766
			private static object MI213DGwjkq6wke40vMR;
		}

		// Token: 0x02000E77 RID: 3703
		[Nullable(0)]
		public class FighterDetails
		{
			// Token: 0x170020B3 RID: 8371
			// (get) Token: 0x0600B109 RID: 45321 RVA: 0x002F5470 File Offset: 0x002F3670
			// (set) Token: 0x0600B10A RID: 45322 RVA: 0x002F5478 File Offset: 0x002F3678
			[JsonProperty("spawnInformation")]
			public FightManager.SpawnInformation SpawnInformation
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020B4 RID: 8372
			// (get) Token: 0x0600B10B RID: 45323 RVA: 0x002F5488 File Offset: 0x002F3688
			// (set) Token: 0x0600B10C RID: 45324 RVA: 0x002F5490 File Offset: 0x002F3690
			[JsonProperty("stats")]
			public FightManager.Stats Stats
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020B5 RID: 8373
			// (get) Token: 0x0600B10D RID: 45325 RVA: 0x002F54A0 File Offset: 0x002F36A0
			// (set) Token: 0x0600B10E RID: 45326 RVA: 0x002F54A8 File Offset: 0x002F36A8
			[JsonProperty("namedFighter")]
			public FightManager.NamedFighter NamedFighter
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B10F RID: 45327 RVA: 0x002F54B8 File Offset: 0x002F36B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public FighterDetails()
			{
			}

			// Token: 0x0600B110 RID: 45328 RVA: 0x002F54C8 File Offset: 0x002F36C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static FighterDetails()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B111 RID: 45329 RVA: 0x002F54DC File Offset: 0x002F36DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool ID2CIEGwl21wpriAy89U()
			{
				return true;
			}

			// Token: 0x0600B112 RID: 45330 RVA: 0x002F54E4 File Offset: 0x002F36E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.FighterDetails k20QCkGwcdcQlYQtVjC2()
			{
				return null;
			}

			// Token: 0x04004182 RID: 16770
			private static object peouptGwkX23WnCLcZ6T;
		}

		// Token: 0x02000E78 RID: 3704
		[Nullable(0)]
		public class SpawnInformation
		{
			// Token: 0x170020B6 RID: 8374
			// (get) Token: 0x0600B113 RID: 45331 RVA: 0x002F54EC File Offset: 0x002F36EC
			// (set) Token: 0x0600B114 RID: 45332 RVA: 0x002F54F4 File Offset: 0x002F36F4
			[JsonProperty("alive")]
			public bool Alive
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return true;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020B7 RID: 8375
			// (get) Token: 0x0600B115 RID: 45333 RVA: 0x002F5504 File Offset: 0x002F3704
			// (set) Token: 0x0600B116 RID: 45334 RVA: 0x002F550C File Offset: 0x002F370C
			[JsonProperty("team")]
			public string Team
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B117 RID: 45335 RVA: 0x002F551C File Offset: 0x002F371C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public SpawnInformation()
			{
			}

			// Token: 0x0600B118 RID: 45336 RVA: 0x002F552C File Offset: 0x002F372C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static SpawnInformation()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B119 RID: 45337 RVA: 0x002F5540 File Offset: 0x002F3740
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool iyl2JmGwvb1pLOO3seZy()
			{
				return true;
			}

			// Token: 0x0600B11A RID: 45338 RVA: 0x002F5548 File Offset: 0x002F3748
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.SpawnInformation queOqaGwooqrExeNqGfb()
			{
				return null;
			}

			// Token: 0x04004185 RID: 16773
			private static object KwbEIIGwUbJmwtD2VupO;
		}

		// Token: 0x02000E79 RID: 3705
		[Nullable(0)]
		public class Stats
		{
			// Token: 0x170020B8 RID: 8376
			// (get) Token: 0x0600B11B RID: 45339 RVA: 0x002F5550 File Offset: 0x002F3750
			// (set) Token: 0x0600B11C RID: 45340 RVA: 0x002F5558 File Offset: 0x002F3758
			[JsonProperty("characteristics")]
			public List<FightManager.Characteristic> Characteristics
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B11D RID: 45341 RVA: 0x002F5560 File Offset: 0x002F3760
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Stats()
			{
			}

			// Token: 0x0600B11E RID: 45342 RVA: 0x002F5570 File Offset: 0x002F3770
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Stats()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B11F RID: 45343 RVA: 0x002F5584 File Offset: 0x002F3784
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool XlBV9pGwauRA33FeaJQE()
			{
				return true;
			}

			// Token: 0x0600B120 RID: 45344 RVA: 0x002F558C File Offset: 0x002F378C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.Stats HQeT28Gw5kcRaHqOJKuo()
			{
				return null;
			}

			// Token: 0x04004187 RID: 16775
			private static object zj6NQHGw160eu0B4D300;
		}

		// Token: 0x02000E7A RID: 3706
		[Nullable(0)]
		public class Characteristic
		{
			// Token: 0x170020B9 RID: 8377
			// (get) Token: 0x0600B121 RID: 45345 RVA: 0x002F5594 File Offset: 0x002F3794
			// (set) Token: 0x0600B122 RID: 45346 RVA: 0x002F559C File Offset: 0x002F379C
			[JsonProperty("characteristicId")]
			public int? CharacteristicId
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020BA RID: 8378
			// (get) Token: 0x0600B123 RID: 45347 RVA: 0x002F55A4 File Offset: 0x002F37A4
			// (set) Token: 0x0600B124 RID: 45348 RVA: 0x002F55AC File Offset: 0x002F37AC
			[JsonProperty("value")]
			public FightManager.CharacteristicValue Value
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B125 RID: 45349 RVA: 0x002F55BC File Offset: 0x002F37BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Characteristic()
			{
			}

			// Token: 0x0600B126 RID: 45350 RVA: 0x002F55CC File Offset: 0x002F37CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Characteristic()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B127 RID: 45351 RVA: 0x002F55E0 File Offset: 0x002F37E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool qnbyWFGw6mPngmah79Ja()
			{
				return true;
			}

			// Token: 0x0600B128 RID: 45352 RVA: 0x002F55E8 File Offset: 0x002F37E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.Characteristic hQjdrQGwLQWGr1u0JN1n()
			{
				return null;
			}

			// Token: 0x0400418A RID: 16778
			internal static object oUU2ZxGwy7D4YvH3hOBC;
		}

		// Token: 0x02000E7B RID: 3707
		[Nullable(0)]
		public class CharacteristicValue
		{
			// Token: 0x170020BB RID: 8379
			// (get) Token: 0x0600B129 RID: 45353 RVA: 0x002F55F0 File Offset: 0x002F37F0
			// (set) Token: 0x0600B12A RID: 45354 RVA: 0x002F55F8 File Offset: 0x002F37F8
			[JsonProperty("total")]
			public string Total
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B12B RID: 45355 RVA: 0x002F5608 File Offset: 0x002F3808
			[MethodImpl(MethodImplOptions.NoInlining)]
			public CharacteristicValue()
			{
			}

			// Token: 0x0600B12C RID: 45356 RVA: 0x002F5618 File Offset: 0x002F3818
			[MethodImpl(MethodImplOptions.NoInlining)]
			static CharacteristicValue()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B12D RID: 45357 RVA: 0x002F562C File Offset: 0x002F382C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool DAyLXGGwhSa77kqOWpIT()
			{
				return true;
			}

			// Token: 0x0600B12E RID: 45358 RVA: 0x002F5634 File Offset: 0x002F3834
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.CharacteristicValue KsjuCtGwrAl7lIVgXNtS()
			{
				return null;
			}

			// Token: 0x0400418C RID: 16780
			private static object eGvUd9GwWCBKRLcEAQZE;
		}

		// Token: 0x02000E7C RID: 3708
		[Nullable(0)]
		public class NamedFighter
		{
			// Token: 0x170020BC RID: 8380
			// (get) Token: 0x0600B12F RID: 45359 RVA: 0x002F563C File Offset: 0x002F383C
			// (set) Token: 0x0600B130 RID: 45360 RVA: 0x002F5644 File Offset: 0x002F3844
			[JsonProperty("name")]
			public string Name
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020BD RID: 8381
			// (get) Token: 0x0600B131 RID: 45361 RVA: 0x002F5654 File Offset: 0x002F3854
			// (set) Token: 0x0600B132 RID: 45362 RVA: 0x002F565C File Offset: 0x002F385C
			[JsonProperty("characterInformation")]
			public FightManager.CharacterInformation CharacterInformation
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B133 RID: 45363 RVA: 0x002F566C File Offset: 0x002F386C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public NamedFighter()
			{
			}

			// Token: 0x0600B134 RID: 45364 RVA: 0x002F567C File Offset: 0x002F387C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static NamedFighter()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B135 RID: 45365 RVA: 0x002F5690 File Offset: 0x002F3890
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool roLc07Gw0ktBAytQF8er()
			{
				return true;
			}

			// Token: 0x0600B136 RID: 45366 RVA: 0x002F5698 File Offset: 0x002F3898
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.NamedFighter zC3CWZGwCFxTqjc7dooh()
			{
				return null;
			}

			// Token: 0x0400418F RID: 16783
			private static object wT21ygGwVFWBuQo6dPiR;
		}

		// Token: 0x02000E7D RID: 3709
		[NullableContext(0)]
		public class CharacterInformation
		{
			// Token: 0x170020BE RID: 8382
			// (get) Token: 0x0600B137 RID: 45367 RVA: 0x002F56A0 File Offset: 0x002F38A0
			// (set) Token: 0x0600B138 RID: 45368 RVA: 0x002F56A8 File Offset: 0x002F38A8
			[JsonProperty("level")]
			public int Level
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B139 RID: 45369 RVA: 0x002F56B8 File Offset: 0x002F38B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public CharacterInformation()
			{
			}

			// Token: 0x0600B13A RID: 45370 RVA: 0x002F56C8 File Offset: 0x002F38C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static CharacterInformation()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B13B RID: 45371 RVA: 0x002F56DC File Offset: 0x002F38DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool OT8AROGwtwdyHLNWOayv()
			{
				return true;
			}

			// Token: 0x0600B13C RID: 45372 RVA: 0x002F56E4 File Offset: 0x002F38E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.CharacterInformation CDqc18GwwN4gvDs2l0kZ()
			{
				return null;
			}

			// Token: 0x04004191 RID: 16785
			private static object JxxU1AGwDr2uHqXCdU5h;
		}

		// Token: 0x02000E7E RID: 3710
		[Nullable(0)]
		public class FightPlacementPossiblePositionsEvent
		{
			// Token: 0x170020BF RID: 8383
			// (get) Token: 0x0600B13D RID: 45373 RVA: 0x002F56EC File Offset: 0x002F38EC
			// (set) Token: 0x0600B13E RID: 45374 RVA: 0x002F56F4 File Offset: 0x002F38F4
			[JsonProperty("startingPositions")]
			public FightManager.StartingPositions StartingPositions
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B13F RID: 45375 RVA: 0x002F5704 File Offset: 0x002F3904
			[MethodImpl(MethodImplOptions.NoInlining)]
			public FightPlacementPossiblePositionsEvent()
			{
			}

			// Token: 0x0600B140 RID: 45376 RVA: 0x002F5714 File Offset: 0x002F3914
			[MethodImpl(MethodImplOptions.NoInlining)]
			static FightPlacementPossiblePositionsEvent()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B141 RID: 45377 RVA: 0x002F5728 File Offset: 0x002F3928
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool uQKmcEGw7WR2tbGu97lr()
			{
				return true;
			}

			// Token: 0x0600B142 RID: 45378 RVA: 0x002F5730 File Offset: 0x002F3930
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.FightPlacementPossiblePositionsEvent BNXHUkGwTwoHnn48rvCl()
			{
				return null;
			}

			// Token: 0x04004193 RID: 16787
			private static object TxXntyGwQjddjpiYT9Bb;
		}

		// Token: 0x02000E7F RID: 3711
		[Nullable(0)]
		public class StartingPositions
		{
			// Token: 0x170020C0 RID: 8384
			// (get) Token: 0x0600B143 RID: 45379 RVA: 0x002F5738 File Offset: 0x002F3938
			// (set) Token: 0x0600B144 RID: 45380 RVA: 0x002F5740 File Offset: 0x002F3940
			[JsonProperty("challengersPositions")]
			public List<int> ChallengersPositions
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020C1 RID: 8385
			// (get) Token: 0x0600B145 RID: 45381 RVA: 0x002F5748 File Offset: 0x002F3948
			// (set) Token: 0x0600B146 RID: 45382 RVA: 0x002F5750 File Offset: 0x002F3950
			[JsonProperty("defendersPositions")]
			public List<int> DefendersPositions
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B147 RID: 45383 RVA: 0x002F5758 File Offset: 0x002F3958
			[MethodImpl(MethodImplOptions.NoInlining)]
			public StartingPositions()
			{
			}

			// Token: 0x0600B148 RID: 45384 RVA: 0x002F5768 File Offset: 0x002F3968
			[MethodImpl(MethodImplOptions.NoInlining)]
			static StartingPositions()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B149 RID: 45385 RVA: 0x002F577C File Offset: 0x002F397C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool RDkdlCGwHcuReLopYLL4()
			{
				return true;
			}

			// Token: 0x0600B14A RID: 45386 RVA: 0x002F5784 File Offset: 0x002F3984
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.StartingPositions AyRFd5GwYw8HZuCTGbkl()
			{
				return null;
			}

			// Token: 0x04004196 RID: 16790
			private static object Cv66dKGwpvQMTERIl9N9;
		}

		// Token: 0x02000E80 RID: 3712
		[Nullable(0)]
		public class FightStartingData
		{
			// Token: 0x170020C2 RID: 8386
			// (get) Token: 0x0600B14B RID: 45387 RVA: 0x002F578C File Offset: 0x002F398C
			// (set) Token: 0x0600B14C RID: 45388 RVA: 0x002F5794 File Offset: 0x002F3994
			[JsonProperty("fightType")]
			public string FightType
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020C3 RID: 8387
			// (get) Token: 0x0600B14D RID: 45389 RVA: 0x002F57A4 File Offset: 0x002F39A4
			// (set) Token: 0x0600B14E RID: 45390 RVA: 0x002F57AC File Offset: 0x002F39AC
			[JsonProperty("fightId")]
			public int FightId
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020C4 RID: 8388
			// (get) Token: 0x0600B14F RID: 45391 RVA: 0x002F57BC File Offset: 0x002F39BC
			// (set) Token: 0x0600B150 RID: 45392 RVA: 0x002F57C4 File Offset: 0x002F39C4
			[JsonProperty("attackerId")]
			public string AttackerId
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020C5 RID: 8389
			// (get) Token: 0x0600B151 RID: 45393 RVA: 0x002F57D4 File Offset: 0x002F39D4
			// (set) Token: 0x0600B152 RID: 45394 RVA: 0x002F57DC File Offset: 0x002F39DC
			[JsonProperty("defenderId")]
			public string DefenderId
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020C6 RID: 8390
			// (get) Token: 0x0600B153 RID: 45395 RVA: 0x002F57EC File Offset: 0x002F39EC
			// (set) Token: 0x0600B154 RID: 45396 RVA: 0x002F57F4 File Offset: 0x002F39F4
			[JsonProperty("monsters")]
			public List<int> Monsters
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B155 RID: 45397 RVA: 0x002F57FC File Offset: 0x002F39FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public FightStartingData()
			{
			}

			// Token: 0x0600B156 RID: 45398 RVA: 0x002F580C File Offset: 0x002F3A0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static FightStartingData()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B157 RID: 45399 RVA: 0x002F5820 File Offset: 0x002F3A20
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool bBVvKCGwiuJtLNn5WsHd()
			{
				return true;
			}

			// Token: 0x0600B158 RID: 45400 RVA: 0x002F5828 File Offset: 0x002F3A28
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.FightStartingData PR6GWAGwPRY6WnnE7Ipk()
			{
				return null;
			}

			// Token: 0x0400419C RID: 16796
			internal static object eQbwwLGwbnhgn1ME3dP8;
		}

		// Token: 0x02000E81 RID: 3713
		[Nullable(0)]
		public class MapMovementData
		{
			// Token: 0x170020C7 RID: 8391
			// (get) Token: 0x0600B159 RID: 45401 RVA: 0x002F5830 File Offset: 0x002F3A30
			// (set) Token: 0x0600B15A RID: 45402 RVA: 0x002F5838 File Offset: 0x002F3A38
			public List<int> Cells
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020C8 RID: 8392
			// (get) Token: 0x0600B15B RID: 45403 RVA: 0x002F5840 File Offset: 0x002F3A40
			// (set) Token: 0x0600B15C RID: 45404 RVA: 0x002F5848 File Offset: 0x002F3A48
			public int Direction
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020C9 RID: 8393
			// (get) Token: 0x0600B15D RID: 45405 RVA: 0x002F5858 File Offset: 0x002F3A58
			// (set) Token: 0x0600B15E RID: 45406 RVA: 0x002F5860 File Offset: 0x002F3A60
			public string CharacterId
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020CA RID: 8394
			// (get) Token: 0x0600B15F RID: 45407 RVA: 0x002F5870 File Offset: 0x002F3A70
			// (set) Token: 0x0600B160 RID: 45408 RVA: 0x002F5878 File Offset: 0x002F3A78
			public bool Cautious
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return true;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B161 RID: 45409 RVA: 0x002F5888 File Offset: 0x002F3A88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public MapMovementData()
			{
			}

			// Token: 0x0600B162 RID: 45410 RVA: 0x002F5898 File Offset: 0x002F3A98
			[MethodImpl(MethodImplOptions.NoInlining)]
			static MapMovementData()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B163 RID: 45411 RVA: 0x002F58AC File Offset: 0x002F3AAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool yhw4aVGwMfUqld5T9qhA()
			{
				return true;
			}

			// Token: 0x0600B164 RID: 45412 RVA: 0x002F58B4 File Offset: 0x002F3AB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.MapMovementData zShAuyGwu4FtBJAOqPoD()
			{
				return null;
			}

			// Token: 0x040041A1 RID: 16801
			private static object FNf7b4GwSt2jlAZra7oL;
		}

		// Token: 0x02000E82 RID: 3714
		[Nullable(0)]
		public class MapMovementEvent
		{
			// Token: 0x170020CB RID: 8395
			// (get) Token: 0x0600B165 RID: 45413 RVA: 0x002F58BC File Offset: 0x002F3ABC
			// (set) Token: 0x0600B166 RID: 45414 RVA: 0x002F58C4 File Offset: 0x002F3AC4
			[JsonProperty("cells")]
			public List<int> Cells
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020CC RID: 8396
			// (get) Token: 0x0600B167 RID: 45415 RVA: 0x002F58CC File Offset: 0x002F3ACC
			// (set) Token: 0x0600B168 RID: 45416 RVA: 0x002F58D4 File Offset: 0x002F3AD4
			[JsonProperty("direction")]
			public int Direction
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020CD RID: 8397
			// (get) Token: 0x0600B169 RID: 45417 RVA: 0x002F58E4 File Offset: 0x002F3AE4
			// (set) Token: 0x0600B16A RID: 45418 RVA: 0x002F58EC File Offset: 0x002F3AEC
			[JsonProperty("characterId")]
			public string CharacterId
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B16B RID: 45419 RVA: 0x002F58FC File Offset: 0x002F3AFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public MapMovementEvent()
			{
			}

			// Token: 0x0600B16C RID: 45420 RVA: 0x002F590C File Offset: 0x002F3B0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static MapMovementEvent()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B16D RID: 45421 RVA: 0x002F5920 File Offset: 0x002F3B20
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool vPuhaAGwZBgrqEyw9GAY()
			{
				return true;
			}

			// Token: 0x0600B16E RID: 45422 RVA: 0x002F5928 File Offset: 0x002F3B28
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.MapMovementEvent EDUlnvGwqmC7OySmXksa()
			{
				return null;
			}

			// Token: 0x040041A5 RID: 16805
			private static object DNhgnjGw8XAoW7ni9fRB;
		}

		// Token: 0x02000E83 RID: 3715
		[Nullable(0)]
		public class FighterData
		{
			// Token: 0x170020CE RID: 8398
			// (get) Token: 0x0600B16F RID: 45423 RVA: 0x002F5930 File Offset: 0x002F3B30
			// (set) Token: 0x0600B170 RID: 45424 RVA: 0x002F5938 File Offset: 0x002F3B38
			public string ActorId
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020CF RID: 8399
			// (get) Token: 0x0600B171 RID: 45425 RVA: 0x002F5948 File Offset: 0x002F3B48
			// (set) Token: 0x0600B172 RID: 45426 RVA: 0x002F5950 File Offset: 0x002F3B50
			public int CellId
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020D0 RID: 8400
			// (get) Token: 0x0600B173 RID: 45427 RVA: 0x002F5960 File Offset: 0x002F3B60
			// (set) Token: 0x0600B174 RID: 45428 RVA: 0x002F5968 File Offset: 0x002F3B68
			public List<int> CellHistory
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020D1 RID: 8401
			// (get) Token: 0x0600B175 RID: 45429 RVA: 0x002F5970 File Offset: 0x002F3B70
			// (set) Token: 0x0600B176 RID: 45430 RVA: 0x002F5978 File Offset: 0x002F3B78
			public string Direction
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020D2 RID: 8402
			// (get) Token: 0x0600B177 RID: 45431 RVA: 0x002F5988 File Offset: 0x002F3B88
			// (set) Token: 0x0600B178 RID: 45432 RVA: 0x002F5990 File Offset: 0x002F3B90
			public bool Alive
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return true;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020D3 RID: 8403
			// (get) Token: 0x0600B179 RID: 45433 RVA: 0x002F59A0 File Offset: 0x002F3BA0
			// (set) Token: 0x0600B17A RID: 45434 RVA: 0x002F59A8 File Offset: 0x002F3BA8
			public Dictionary<int, int> Characteristics
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020D4 RID: 8404
			// (get) Token: 0x0600B17B RID: 45435 RVA: 0x002F59B0 File Offset: 0x002F3BB0
			// (set) Token: 0x0600B17C RID: 45436 RVA: 0x002F59B8 File Offset: 0x002F3BB8
			public string Name
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020D5 RID: 8405
			// (get) Token: 0x0600B17D RID: 45437 RVA: 0x002F59C8 File Offset: 0x002F3BC8
			// (set) Token: 0x0600B17E RID: 45438 RVA: 0x002F59D0 File Offset: 0x002F3BD0
			public int Level
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020D6 RID: 8406
			// (get) Token: 0x0600B17F RID: 45439 RVA: 0x002F59E0 File Offset: 0x002F3BE0
			// (set) Token: 0x0600B180 RID: 45440 RVA: 0x002F59E8 File Offset: 0x002F3BE8
			public string Team
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x170020D7 RID: 8407
			// (get) Token: 0x0600B181 RID: 45441 RVA: 0x002F59F8 File Offset: 0x002F3BF8
			// (set) Token: 0x0600B182 RID: 45442 RVA: 0x002F5A00 File Offset: 0x002F3C00
			public int Life
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x0600B183 RID: 45443 RVA: 0x002F5A10 File Offset: 0x002F3C10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public FighterData()
			{
			}

			// Token: 0x0600B184 RID: 45444 RVA: 0x002F5A20 File Offset: 0x002F3C20
			[MethodImpl(MethodImplOptions.NoInlining)]
			static FighterData()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0600B185 RID: 45445 RVA: 0x002F5A34 File Offset: 0x002F3C34
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool xfcpcQGwzcoTlIyxx9EW()
			{
				return true;
			}

			// Token: 0x0600B186 RID: 45446 RVA: 0x002F5A3C File Offset: 0x002F3C3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static FightManager.FighterData IpB1k8GQfLgJ953pooqJ()
			{
				return null;
			}

			// Token: 0x040041B0 RID: 16816
			private static object KIbcsAGwFDEL5hg8E2E4;
		}
	}
}
