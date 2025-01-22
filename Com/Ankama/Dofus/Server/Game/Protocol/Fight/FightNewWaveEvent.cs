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
	// Token: 0x02000671 RID: 1649
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightNewWaveEvent : IMessage<FightNewWaveEvent>, IMessage, IEquatable<FightNewWaveEvent>, IDeepCloneable<FightNewWaveEvent>, IBufferMessage
	{
		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06005060 RID: 20576 RVA: 0x00204BF0 File Offset: 0x00202DF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightNewWaveEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06005061 RID: 20577 RVA: 0x00204C00 File Offset: 0x00202E00
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

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06005062 RID: 20578 RVA: 0x00204C10 File Offset: 0x00202E10
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

		// Token: 0x06005063 RID: 20579 RVA: 0x00204C20 File Offset: 0x00202E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightNewWaveEvent()
		{
		}

		// Token: 0x06005064 RID: 20580 RVA: 0x00204C30 File Offset: 0x00202E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightNewWaveEvent(FightNewWaveEvent other)
		{
		}

		// Token: 0x06005065 RID: 20581 RVA: 0x00204C40 File Offset: 0x00202E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightNewWaveEvent Clone()
		{
			return null;
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06005066 RID: 20582 RVA: 0x00204C50 File Offset: 0x00202E50
		// (set) Token: 0x06005067 RID: 20583 RVA: 0x00204C60 File Offset: 0x00202E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveId
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

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06005068 RID: 20584 RVA: 0x00204C70 File Offset: 0x00202E70
		// (set) Token: 0x06005069 RID: 20585 RVA: 0x00204C84 File Offset: 0x00202E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Team Team
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Team)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x0600506A RID: 20586 RVA: 0x00204C94 File Offset: 0x00202E94
		// (set) Token: 0x0600506B RID: 20587 RVA: 0x00204CA4 File Offset: 0x00202EA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int TurnLeftBeforeNextWave
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

		// Token: 0x0600506C RID: 20588 RVA: 0x00204CB4 File Offset: 0x00202EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600506D RID: 20589 RVA: 0x00204CC4 File Offset: 0x00202EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightNewWaveEvent other)
		{
			return true;
		}

		// Token: 0x0600506E RID: 20590 RVA: 0x00204CD4 File Offset: 0x00202ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600506F RID: 20591 RVA: 0x00204CE4 File Offset: 0x00202EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005070 RID: 20592 RVA: 0x00204CF4 File Offset: 0x00202EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005071 RID: 20593 RVA: 0x00204D04 File Offset: 0x00202F04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005072 RID: 20594 RVA: 0x00204D14 File Offset: 0x00202F14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x00204D24 File Offset: 0x00202F24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightNewWaveEvent other)
		{
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x00204D34 File Offset: 0x00202F34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005075 RID: 20597 RVA: 0x00204D44 File Offset: 0x00202F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005076 RID: 20598 RVA: 0x00204D54 File Offset: 0x00202F54
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightNewWaveEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 3:
					return;
				case 4:
					FightNewWaveEvent._parser = new MessageParser<FightNewWaveEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x00204E38 File Offset: 0x00203038
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JM3nIuOiY1YBlC9jwjDv()
		{
			return true;
		}

		// Token: 0x06005078 RID: 20600 RVA: 0x00204E40 File Offset: 0x00203040
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightNewWaveEvent YZdsO7OibK3IM7OGPuxI()
		{
			return null;
		}

		// Token: 0x04001C45 RID: 7237
		private static readonly MessageParser<FightNewWaveEvent> _parser;

		// Token: 0x04001C46 RID: 7238
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C47 RID: 7239
		public const int WaveIdFieldNumber = 1;

		// Token: 0x04001C48 RID: 7240
		private int waveId_;

		// Token: 0x04001C49 RID: 7241
		public const int TeamFieldNumber = 2;

		// Token: 0x04001C4A RID: 7242
		private Team team_;

		// Token: 0x04001C4B RID: 7243
		public const int TurnLeftBeforeNextWaveFieldNumber = 3;

		// Token: 0x04001C4C RID: 7244
		private int turnLeftBeforeNextWave_;

		// Token: 0x04001C4D RID: 7245
		private static FightNewWaveEvent z3U22BOiHOEHUxSDey5k;
	}
}
