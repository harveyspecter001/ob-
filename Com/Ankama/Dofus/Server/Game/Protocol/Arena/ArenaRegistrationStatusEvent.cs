using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C12 RID: 3090
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ArenaRegistrationStatusEvent : IMessage<ArenaRegistrationStatusEvent>, IMessage, IEquatable<ArenaRegistrationStatusEvent>, IDeepCloneable<ArenaRegistrationStatusEvent>, IBufferMessage
	{
		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x06009479 RID: 38009 RVA: 0x002763B8 File Offset: 0x002745B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ArenaRegistrationStatusEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x0600947A RID: 38010 RVA: 0x002763C8 File Offset: 0x002745C8
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

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x0600947B RID: 38011 RVA: 0x002763D8 File Offset: 0x002745D8
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

		// Token: 0x0600947C RID: 38012 RVA: 0x002763E8 File Offset: 0x002745E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaRegistrationStatusEvent()
		{
		}

		// Token: 0x0600947D RID: 38013 RVA: 0x002763F8 File Offset: 0x002745F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaRegistrationStatusEvent(ArenaRegistrationStatusEvent other)
		{
		}

		// Token: 0x0600947E RID: 38014 RVA: 0x00276408 File Offset: 0x00274608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaRegistrationStatusEvent Clone()
		{
			return null;
		}

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x0600947F RID: 38015 RVA: 0x00276418 File Offset: 0x00274618
		// (set) Token: 0x06009480 RID: 38016 RVA: 0x00276428 File Offset: 0x00274628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Registered
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

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x06009481 RID: 38017 RVA: 0x00276438 File Offset: 0x00274638
		// (set) Token: 0x06009482 RID: 38018 RVA: 0x0027644C File Offset: 0x0027464C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArenaRegistrationStatusEvent.Types.Step Step
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ArenaRegistrationStatusEvent.Types.Step)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x06009483 RID: 38019 RVA: 0x0027645C File Offset: 0x0027465C
		// (set) Token: 0x06009484 RID: 38020 RVA: 0x00276470 File Offset: 0x00274670
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ArenaType BattleMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ArenaType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06009485 RID: 38021 RVA: 0x00276480 File Offset: 0x00274680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009486 RID: 38022 RVA: 0x00276490 File Offset: 0x00274690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ArenaRegistrationStatusEvent other)
		{
			return true;
		}

		// Token: 0x06009487 RID: 38023 RVA: 0x002764A0 File Offset: 0x002746A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009488 RID: 38024 RVA: 0x002764B0 File Offset: 0x002746B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009489 RID: 38025 RVA: 0x002764C0 File Offset: 0x002746C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600948A RID: 38026 RVA: 0x002764D0 File Offset: 0x002746D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600948B RID: 38027 RVA: 0x002764E0 File Offset: 0x002746E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600948C RID: 38028 RVA: 0x002764F0 File Offset: 0x002746F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ArenaRegistrationStatusEvent other)
		{
		}

		// Token: 0x0600948D RID: 38029 RVA: 0x00276500 File Offset: 0x00274700
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600948E RID: 38030 RVA: 0x00276510 File Offset: 0x00274710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600948F RID: 38031 RVA: 0x00276520 File Offset: 0x00274720
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ArenaRegistrationStatusEvent()
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
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					ArenaRegistrationStatusEvent._parser = new MessageParser<ArenaRegistrationStatusEvent>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06009490 RID: 38032 RVA: 0x00276604 File Offset: 0x00274804
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mX4QueJX4vPsymstxsPN()
		{
			return true;
		}

		// Token: 0x06009491 RID: 38033 RVA: 0x0027660C File Offset: 0x0027480C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ArenaRegistrationStatusEvent BcIX6eJXjHE0fFgGNu3D()
		{
			return null;
		}

		// Token: 0x0400373F RID: 14143
		private static readonly MessageParser<ArenaRegistrationStatusEvent> _parser;

		// Token: 0x04003740 RID: 14144
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003741 RID: 14145
		public const int RegisteredFieldNumber = 1;

		// Token: 0x04003742 RID: 14146
		private bool registered_;

		// Token: 0x04003743 RID: 14147
		public const int StepFieldNumber = 2;

		// Token: 0x04003744 RID: 14148
		private ArenaRegistrationStatusEvent.Types.Step step_;

		// Token: 0x04003745 RID: 14149
		public const int BattleModeFieldNumber = 3;

		// Token: 0x04003746 RID: 14150
		private ArenaType battleMode_;

		// Token: 0x04003747 RID: 14151
		internal static ArenaRegistrationStatusEvent tFGGxmJXxgD1aGJioXNV;

		// Token: 0x02000C13 RID: 3091
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06009492 RID: 38034 RVA: 0x002E79EC File Offset: 0x002E5BEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000C14 RID: 3092
			public enum Step
			{
				// Token: 0x04003749 RID: 14153
				[OriginalName("REGISTERED")]
				Registered,
				// Token: 0x0400374A RID: 14154
				[OriginalName("WAITING_FIGHT")]
				WaitingFight,
				// Token: 0x0400374B RID: 14155
				[OriginalName("STARTING_FIGHT")]
				StartingFight,
				// Token: 0x0400374C RID: 14156
				[OriginalName("UNREGISTERED")]
				Unregistered
			}
		}
	}
}
