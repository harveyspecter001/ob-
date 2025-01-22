using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x02000684 RID: 1668
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightSynchronizeEvent : IMessage<FightSynchronizeEvent>, IMessage, IEquatable<FightSynchronizeEvent>, IDeepCloneable<FightSynchronizeEvent>, IBufferMessage
	{
		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x0600515A RID: 20826 RVA: 0x00205DB4 File Offset: 0x00203FB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightSynchronizeEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x0600515B RID: 20827 RVA: 0x00205DC4 File Offset: 0x00203FC4
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

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x0600515C RID: 20828 RVA: 0x00205DD4 File Offset: 0x00203FD4
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

		// Token: 0x0600515D RID: 20829 RVA: 0x00205DE4 File Offset: 0x00203FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightSynchronizeEvent()
		{
		}

		// Token: 0x0600515E RID: 20830 RVA: 0x00205DF4 File Offset: 0x00203FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightSynchronizeEvent(FightSynchronizeEvent other)
		{
		}

		// Token: 0x0600515F RID: 20831 RVA: 0x00205E04 File Offset: 0x00204004
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightSynchronizeEvent Clone()
		{
			return null;
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06005160 RID: 20832 RVA: 0x00205E14 File Offset: 0x00204014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActorPositionInformation> Fighters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005161 RID: 20833 RVA: 0x00205E24 File Offset: 0x00204024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005162 RID: 20834 RVA: 0x00205E34 File Offset: 0x00204034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightSynchronizeEvent other)
		{
			return true;
		}

		// Token: 0x06005163 RID: 20835 RVA: 0x00205E44 File Offset: 0x00204044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005164 RID: 20836 RVA: 0x00205E54 File Offset: 0x00204054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005165 RID: 20837 RVA: 0x00205E64 File Offset: 0x00204064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005166 RID: 20838 RVA: 0x00205E74 File Offset: 0x00204074
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005167 RID: 20839 RVA: 0x00205E84 File Offset: 0x00204084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005168 RID: 20840 RVA: 0x00205E94 File Offset: 0x00204094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightSynchronizeEvent other)
		{
		}

		// Token: 0x06005169 RID: 20841 RVA: 0x00205EA4 File Offset: 0x002040A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600516A RID: 20842 RVA: 0x00205EB4 File Offset: 0x002040B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600516B RID: 20843 RVA: 0x00205EC4 File Offset: 0x002040C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightSynchronizeEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					FightSynchronizeEvent._parser = new MessageParser<FightSynchronizeEvent>(() => null);
					num2 = 5;
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 5:
					FightSynchronizeEvent._repeated_fighters_codec = FieldCodec.ForMessage<ActorPositionInformation>(10U, qqeH7gmD07JZLA3m1WUC.XVInXhlssT(qqeH7gmD07JZLA3m1WUC.Nt8mDCI6NhO));
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x00205FE0 File Offset: 0x002041E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FaslShOPspgX253meGSr()
		{
			return true;
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x00205FE8 File Offset: 0x002041E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightSynchronizeEvent Fq02CuOPdMp6wApKO43S()
		{
			return null;
		}

		// Token: 0x04001C99 RID: 7321
		private static readonly MessageParser<FightSynchronizeEvent> _parser;

		// Token: 0x04001C9A RID: 7322
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C9B RID: 7323
		public const int FightersFieldNumber = 1;

		// Token: 0x04001C9C RID: 7324
		private static readonly FieldCodec<ActorPositionInformation> _repeated_fighters_codec;

		// Token: 0x04001C9D RID: 7325
		private readonly RepeatedField<ActorPositionInformation> fighters_;

		// Token: 0x04001C9E RID: 7326
		internal static FightSynchronizeEvent eCEJ2ROPgNANyJSGuj0C;
	}
}
