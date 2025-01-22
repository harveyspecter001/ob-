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
	// Token: 0x02000B9C RID: 2972
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountData : IMessage<MountData>, IMessage, IEquatable<MountData>, IDeepCloneable<MountData>, IBufferMessage
	{
		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x06008EC7 RID: 36551 RVA: 0x0026C268 File Offset: 0x0026A468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MountData> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x06008EC8 RID: 36552 RVA: 0x0026C278 File Offset: 0x0026A478
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

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x06008EC9 RID: 36553 RVA: 0x0026C288 File Offset: 0x0026A488
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

		// Token: 0x06008ECA RID: 36554 RVA: 0x0026C298 File Offset: 0x0026A498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountData()
		{
		}

		// Token: 0x06008ECB RID: 36555 RVA: 0x0026C2A8 File Offset: 0x0026A4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountData(MountData other)
		{
		}

		// Token: 0x06008ECC RID: 36556 RVA: 0x0026C2B8 File Offset: 0x0026A4B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountData Clone()
		{
			return null;
		}

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x06008ECD RID: 36557 RVA: 0x0026C2C8 File Offset: 0x0026A4C8
		// (set) Token: 0x06008ECE RID: 36558 RVA: 0x0026C2D8 File Offset: 0x0026A4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x06008ECF RID: 36559 RVA: 0x0026C2E8 File Offset: 0x0026A4E8
		// (set) Token: 0x06008ED0 RID: 36560 RVA: 0x0026C2F8 File Offset: 0x0026A4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ModelId
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

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x06008ED1 RID: 36561 RVA: 0x0026C308 File Offset: 0x0026A508
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> Ancestors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x06008ED2 RID: 36562 RVA: 0x0026C318 File Offset: 0x0026A518
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> Behaviors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x06008ED3 RID: 36563 RVA: 0x0026C328 File Offset: 0x0026A528
		// (set) Token: 0x06008ED4 RID: 36564 RVA: 0x0026C338 File Offset: 0x0026A538
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x06008ED5 RID: 36565 RVA: 0x0026C348 File Offset: 0x0026A548
		// (set) Token: 0x06008ED6 RID: 36566 RVA: 0x0026C35C File Offset: 0x0026A55C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Gender Gender
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Gender)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x06008ED7 RID: 36567 RVA: 0x0026C36C File Offset: 0x0026A56C
		// (set) Token: 0x06008ED8 RID: 36568 RVA: 0x0026C37C File Offset: 0x0026A57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OwnerId
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

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x06008ED9 RID: 36569 RVA: 0x0026C38C File Offset: 0x0026A58C
		// (set) Token: 0x06008EDA RID: 36570 RVA: 0x0026C39C File Offset: 0x0026A59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Experience
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

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x06008EDB RID: 36571 RVA: 0x0026C3AC File Offset: 0x0026A5AC
		// (set) Token: 0x06008EDC RID: 36572 RVA: 0x0026C3BC File Offset: 0x0026A5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ExperienceForLevel
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

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x06008EDD RID: 36573 RVA: 0x0026C3CC File Offset: 0x0026A5CC
		// (set) Token: 0x06008EDE RID: 36574 RVA: 0x0026C3DC File Offset: 0x0026A5DC
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

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x06008EDF RID: 36575 RVA: 0x0026C3EC File Offset: 0x0026A5EC
		// (set) Token: 0x06008EE0 RID: 36576 RVA: 0x0026C3FC File Offset: 0x0026A5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRideable
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

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x06008EE1 RID: 36577 RVA: 0x0026C40C File Offset: 0x0026A60C
		// (set) Token: 0x06008EE2 RID: 36578 RVA: 0x0026C41C File Offset: 0x0026A61C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MaxPods
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

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x06008EE3 RID: 36579 RVA: 0x0026C42C File Offset: 0x0026A62C
		// (set) Token: 0x06008EE4 RID: 36580 RVA: 0x0026C43C File Offset: 0x0026A63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsWild
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

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x06008EE5 RID: 36581 RVA: 0x0026C44C File Offset: 0x0026A64C
		// (set) Token: 0x06008EE6 RID: 36582 RVA: 0x0026C45C File Offset: 0x0026A65C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Stamina
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

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x06008EE7 RID: 36583 RVA: 0x0026C46C File Offset: 0x0026A66C
		// (set) Token: 0x06008EE8 RID: 36584 RVA: 0x0026C47C File Offset: 0x0026A67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StaminaMax
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

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x06008EE9 RID: 36585 RVA: 0x0026C48C File Offset: 0x0026A68C
		// (set) Token: 0x06008EEA RID: 36586 RVA: 0x0026C49C File Offset: 0x0026A69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Maturity
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

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x06008EEB RID: 36587 RVA: 0x0026C4AC File Offset: 0x0026A6AC
		// (set) Token: 0x06008EEC RID: 36588 RVA: 0x0026C4BC File Offset: 0x0026A6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaturityForAdult
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

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x06008EED RID: 36589 RVA: 0x0026C4CC File Offset: 0x0026A6CC
		// (set) Token: 0x06008EEE RID: 36590 RVA: 0x0026C4DC File Offset: 0x0026A6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Energy
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

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x06008EEF RID: 36591 RVA: 0x0026C4EC File Offset: 0x0026A6EC
		// (set) Token: 0x06008EF0 RID: 36592 RVA: 0x0026C4FC File Offset: 0x0026A6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EnergyMax
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

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x06008EF1 RID: 36593 RVA: 0x0026C50C File Offset: 0x0026A70C
		// (set) Token: 0x06008EF2 RID: 36594 RVA: 0x0026C51C File Offset: 0x0026A71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Serenity
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

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x06008EF3 RID: 36595 RVA: 0x0026C52C File Offset: 0x0026A72C
		// (set) Token: 0x06008EF4 RID: 36596 RVA: 0x0026C53C File Offset: 0x0026A73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AggressivenessMax
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

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x06008EF5 RID: 36597 RVA: 0x0026C54C File Offset: 0x0026A74C
		// (set) Token: 0x06008EF6 RID: 36598 RVA: 0x0026C55C File Offset: 0x0026A75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SerenityMax
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

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x06008EF7 RID: 36599 RVA: 0x0026C56C File Offset: 0x0026A76C
		// (set) Token: 0x06008EF8 RID: 36600 RVA: 0x0026C57C File Offset: 0x0026A77C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Love
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

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x06008EF9 RID: 36601 RVA: 0x0026C58C File Offset: 0x0026A78C
		// (set) Token: 0x06008EFA RID: 36602 RVA: 0x0026C59C File Offset: 0x0026A79C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int LoveMax
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

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x06008EFB RID: 36603 RVA: 0x0026C5AC File Offset: 0x0026A7AC
		// (set) Token: 0x06008EFC RID: 36604 RVA: 0x0026C5BC File Offset: 0x0026A7BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FertilizationTime
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

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x06008EFD RID: 36605 RVA: 0x0026C5CC File Offset: 0x0026A7CC
		// (set) Token: 0x06008EFE RID: 36606 RVA: 0x0026C5DC File Offset: 0x0026A7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFertilizationReady
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

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x06008EFF RID: 36607 RVA: 0x0026C5EC File Offset: 0x0026A7EC
		// (set) Token: 0x06008F00 RID: 36608 RVA: 0x0026C5FC File Offset: 0x0026A7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoostLimiter
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

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x06008F01 RID: 36609 RVA: 0x0026C60C File Offset: 0x0026A80C
		// (set) Token: 0x06008F02 RID: 36610 RVA: 0x0026C61C File Offset: 0x0026A81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BoostMax
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

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x06008F03 RID: 36611 RVA: 0x0026C62C File Offset: 0x0026A82C
		// (set) Token: 0x06008F04 RID: 36612 RVA: 0x0026C63C File Offset: 0x0026A83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReproductionCount
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

		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x06008F05 RID: 36613 RVA: 0x0026C64C File Offset: 0x0026A84C
		// (set) Token: 0x06008F06 RID: 36614 RVA: 0x0026C65C File Offset: 0x0026A85C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long ReproductionCountMax
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

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x06008F07 RID: 36615 RVA: 0x0026C66C File Offset: 0x0026A86C
		// (set) Token: 0x06008F08 RID: 36616 RVA: 0x0026C67C File Offset: 0x0026A87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HarnessGid
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

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x06008F09 RID: 36617 RVA: 0x0026C68C File Offset: 0x0026A88C
		// (set) Token: 0x06008F0A RID: 36618 RVA: 0x0026C69C File Offset: 0x0026A89C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool UseHarnessColors
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

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x06008F0B RID: 36619 RVA: 0x0026C6AC File Offset: 0x0026A8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectEffect> Effects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x06008F0C RID: 36620 RVA: 0x0026C6BC File Offset: 0x0026A8BC
		// (set) Token: 0x06008F0D RID: 36621 RVA: 0x0026C6CC File Offset: 0x0026A8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ExperienceForNextLevel
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

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x06008F0E RID: 36622 RVA: 0x0026C6DC File Offset: 0x0026A8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasExperienceForNextLevel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06008F0F RID: 36623 RVA: 0x0026C6EC File Offset: 0x0026A8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearExperienceForNextLevel()
		{
		}

		// Token: 0x06008F10 RID: 36624 RVA: 0x0026C6FC File Offset: 0x0026A8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008F11 RID: 36625 RVA: 0x0026C70C File Offset: 0x0026A90C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountData other)
		{
			return true;
		}

		// Token: 0x06008F12 RID: 36626 RVA: 0x0026C71C File Offset: 0x0026A91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008F13 RID: 36627 RVA: 0x0026C72C File Offset: 0x0026A92C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008F14 RID: 36628 RVA: 0x0026C73C File Offset: 0x0026A93C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008F15 RID: 36629 RVA: 0x0026C74C File Offset: 0x0026A94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008F16 RID: 36630 RVA: 0x0026C75C File Offset: 0x0026A95C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008F17 RID: 36631 RVA: 0x0026C76C File Offset: 0x0026A96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountData other)
		{
		}

		// Token: 0x06008F18 RID: 36632 RVA: 0x0026C77C File Offset: 0x0026A97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008F19 RID: 36633 RVA: 0x0026C78C File Offset: 0x0026A98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008F1A RID: 36634 RVA: 0x0026C79C File Offset: 0x0026A99C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountData()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 7;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					MountData._repeated_ancestors_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(26U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 4;
					continue;
				case 2:
					MountData.ExperienceForNextLevelDefaultValue = 0L;
					num2 = 8;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 4:
					MountData._repeated_behaviors_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(34U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					MountData._parser = new MessageParser<MountData>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 6:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					continue;
				case 7:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 6;
					continue;
				case 8:
					return;
				}
				MountData._repeated_effects_codec = FieldCodec.ForMessage<ObjectEffect>(274U, P1SsVKnf4KAo6qkGT9ff.XVInXhlssT(P1SsVKnf4KAo6qkGT9ff.HVGnfjmP83g));
				num2 = 2;
			}
		}

		// Token: 0x06008F1B RID: 36635 RVA: 0x0026C8F8 File Offset: 0x0026AAF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool REhwIHJ9q4ngN3Ut5qms()
		{
			return true;
		}

		// Token: 0x06008F1C RID: 36636 RVA: 0x0026C900 File Offset: 0x0026AB00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountData xXU8ciJ9FCs8SQEcSHru()
		{
			return null;
		}

		// Token: 0x04003501 RID: 13569
		private static readonly MessageParser<MountData> _parser;

		// Token: 0x04003502 RID: 13570
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003503 RID: 13571
		private int _hasBits0;

		// Token: 0x04003504 RID: 13572
		public const int IdFieldNumber = 1;

		// Token: 0x04003505 RID: 13573
		private long id_;

		// Token: 0x04003506 RID: 13574
		public const int ModelIdFieldNumber = 2;

		// Token: 0x04003507 RID: 13575
		private int modelId_;

		// Token: 0x04003508 RID: 13576
		public const int AncestorsFieldNumber = 3;

		// Token: 0x04003509 RID: 13577
		private static readonly FieldCodec<int> _repeated_ancestors_codec;

		// Token: 0x0400350A RID: 13578
		private readonly RepeatedField<int> ancestors_;

		// Token: 0x0400350B RID: 13579
		public const int BehaviorsFieldNumber = 4;

		// Token: 0x0400350C RID: 13580
		private static readonly FieldCodec<int> _repeated_behaviors_codec;

		// Token: 0x0400350D RID: 13581
		private readonly RepeatedField<int> behaviors_;

		// Token: 0x0400350E RID: 13582
		public const int NameFieldNumber = 5;

		// Token: 0x0400350F RID: 13583
		private string name_;

		// Token: 0x04003510 RID: 13584
		public const int GenderFieldNumber = 6;

		// Token: 0x04003511 RID: 13585
		private Gender gender_;

		// Token: 0x04003512 RID: 13586
		public const int OwnerIdFieldNumber = 7;

		// Token: 0x04003513 RID: 13587
		private long ownerId_;

		// Token: 0x04003514 RID: 13588
		public const int ExperienceFieldNumber = 8;

		// Token: 0x04003515 RID: 13589
		private long experience_;

		// Token: 0x04003516 RID: 13590
		public const int ExperienceForLevelFieldNumber = 9;

		// Token: 0x04003517 RID: 13591
		private long experienceForLevel_;

		// Token: 0x04003518 RID: 13592
		public const int LevelFieldNumber = 11;

		// Token: 0x04003519 RID: 13593
		private int level_;

		// Token: 0x0400351A RID: 13594
		public const int IsRideableFieldNumber = 12;

		// Token: 0x0400351B RID: 13595
		private bool isRideable_;

		// Token: 0x0400351C RID: 13596
		public const int MaxPodsFieldNumber = 13;

		// Token: 0x0400351D RID: 13597
		private int maxPods_;

		// Token: 0x0400351E RID: 13598
		public const int IsWildFieldNumber = 14;

		// Token: 0x0400351F RID: 13599
		private bool isWild_;

		// Token: 0x04003520 RID: 13600
		public const int StaminaFieldNumber = 15;

		// Token: 0x04003521 RID: 13601
		private int stamina_;

		// Token: 0x04003522 RID: 13602
		public const int StaminaMaxFieldNumber = 16;

		// Token: 0x04003523 RID: 13603
		private int staminaMax_;

		// Token: 0x04003524 RID: 13604
		public const int MaturityFieldNumber = 17;

		// Token: 0x04003525 RID: 13605
		private int maturity_;

		// Token: 0x04003526 RID: 13606
		public const int MaturityForAdultFieldNumber = 18;

		// Token: 0x04003527 RID: 13607
		private int maturityForAdult_;

		// Token: 0x04003528 RID: 13608
		public const int EnergyFieldNumber = 19;

		// Token: 0x04003529 RID: 13609
		private int energy_;

		// Token: 0x0400352A RID: 13610
		public const int EnergyMaxFieldNumber = 20;

		// Token: 0x0400352B RID: 13611
		private int energyMax_;

		// Token: 0x0400352C RID: 13612
		public const int SerenityFieldNumber = 21;

		// Token: 0x0400352D RID: 13613
		private int serenity_;

		// Token: 0x0400352E RID: 13614
		public const int AggressivenessMaxFieldNumber = 22;

		// Token: 0x0400352F RID: 13615
		private int aggressivenessMax_;

		// Token: 0x04003530 RID: 13616
		public const int SerenityMaxFieldNumber = 23;

		// Token: 0x04003531 RID: 13617
		private int serenityMax_;

		// Token: 0x04003532 RID: 13618
		public const int LoveFieldNumber = 24;

		// Token: 0x04003533 RID: 13619
		private int love_;

		// Token: 0x04003534 RID: 13620
		public const int LoveMaxFieldNumber = 25;

		// Token: 0x04003535 RID: 13621
		private int loveMax_;

		// Token: 0x04003536 RID: 13622
		public const int FertilizationTimeFieldNumber = 26;

		// Token: 0x04003537 RID: 13623
		private int fertilizationTime_;

		// Token: 0x04003538 RID: 13624
		public const int IsFertilizationReadyFieldNumber = 27;

		// Token: 0x04003539 RID: 13625
		private bool isFertilizationReady_;

		// Token: 0x0400353A RID: 13626
		public const int BoostLimiterFieldNumber = 28;

		// Token: 0x0400353B RID: 13627
		private int boostLimiter_;

		// Token: 0x0400353C RID: 13628
		public const int BoostMaxFieldNumber = 29;

		// Token: 0x0400353D RID: 13629
		private long boostMax_;

		// Token: 0x0400353E RID: 13630
		public const int ReproductionCountFieldNumber = 30;

		// Token: 0x0400353F RID: 13631
		private int reproductionCount_;

		// Token: 0x04003540 RID: 13632
		public const int ReproductionCountMaxFieldNumber = 31;

		// Token: 0x04003541 RID: 13633
		private long reproductionCountMax_;

		// Token: 0x04003542 RID: 13634
		public const int HarnessGidFieldNumber = 32;

		// Token: 0x04003543 RID: 13635
		private int harnessGid_;

		// Token: 0x04003544 RID: 13636
		public const int UseHarnessColorsFieldNumber = 33;

		// Token: 0x04003545 RID: 13637
		private bool useHarnessColors_;

		// Token: 0x04003546 RID: 13638
		public const int EffectsFieldNumber = 34;

		// Token: 0x04003547 RID: 13639
		private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

		// Token: 0x04003548 RID: 13640
		private readonly RepeatedField<ObjectEffect> effects_;

		// Token: 0x04003549 RID: 13641
		public const int ExperienceForNextLevelFieldNumber = 10;

		// Token: 0x0400354A RID: 13642
		private static readonly long ExperienceForNextLevelDefaultValue;

		// Token: 0x0400354B RID: 13643
		private long experienceForNextLevel_;

		// Token: 0x0400354C RID: 13644
		internal static MountData mc7uQ0J9Z9QBRvqb3yqc;
	}
}
