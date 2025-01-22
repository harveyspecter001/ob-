using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C26 RID: 3110
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ArenaPlayerBehavioursEvent : IMessage<ArenaPlayerBehavioursEvent>, IMessage, IEquatable<ArenaPlayerBehavioursEvent>, IDeepCloneable<ArenaPlayerBehavioursEvent>, IBufferMessage
	{
		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x06009575 RID: 38261 RVA: 0x002771F8 File Offset: 0x002753F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ArenaPlayerBehavioursEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x06009576 RID: 38262 RVA: 0x00277208 File Offset: 0x00275408
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

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x06009577 RID: 38263 RVA: 0x00277218 File Offset: 0x00275418
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

		// Token: 0x06009578 RID: 38264 RVA: 0x00277228 File Offset: 0x00275428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaPlayerBehavioursEvent()
		{
		}

		// Token: 0x06009579 RID: 38265 RVA: 0x00277238 File Offset: 0x00275438
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaPlayerBehavioursEvent(ArenaPlayerBehavioursEvent other)
		{
		}

		// Token: 0x0600957A RID: 38266 RVA: 0x00277248 File Offset: 0x00275448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaPlayerBehavioursEvent Clone()
		{
			return null;
		}

		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x0600957B RID: 38267 RVA: 0x00277258 File Offset: 0x00275458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Flags
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x0600957C RID: 38268 RVA: 0x00277268 File Offset: 0x00275468
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<string> Sanctions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x0600957D RID: 38269 RVA: 0x00277278 File Offset: 0x00275478
		// (set) Token: 0x0600957E RID: 38270 RVA: 0x00277288 File Offset: 0x00275488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BanDuration
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

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x0600957F RID: 38271 RVA: 0x00277298 File Offset: 0x00275498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasBanDuration
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06009580 RID: 38272 RVA: 0x002772A8 File Offset: 0x002754A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearBanDuration()
		{
		}

		// Token: 0x06009581 RID: 38273 RVA: 0x002772B8 File Offset: 0x002754B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009582 RID: 38274 RVA: 0x002772C8 File Offset: 0x002754C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ArenaPlayerBehavioursEvent other)
		{
			return true;
		}

		// Token: 0x06009583 RID: 38275 RVA: 0x002772D8 File Offset: 0x002754D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009584 RID: 38276 RVA: 0x002772E8 File Offset: 0x002754E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009585 RID: 38277 RVA: 0x002772F8 File Offset: 0x002754F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009586 RID: 38278 RVA: 0x00277308 File Offset: 0x00275508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009587 RID: 38279 RVA: 0x00277318 File Offset: 0x00275518
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009588 RID: 38280 RVA: 0x00277328 File Offset: 0x00275528
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ArenaPlayerBehavioursEvent other)
		{
		}

		// Token: 0x06009589 RID: 38281 RVA: 0x00277338 File Offset: 0x00275538
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600958A RID: 38282 RVA: 0x00277348 File Offset: 0x00275548
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600958B RID: 38283 RVA: 0x00277358 File Offset: 0x00275558
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ArenaPlayerBehavioursEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						ArenaPlayerBehavioursEvent._repeated_flags_codec = UhvKwdMSigIudSGM6ge.XVInXhlssT(10U, UhvKwdMSigIudSGM6ge.BvYMM58cmD);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						ArenaPlayerBehavioursEvent._repeated_sanctions_codec = UhvKwdMSigIudSGM6ge.XVInXhlssT(18U, UhvKwdMSigIudSGM6ge.BvYMM58cmD);
						num2 = 6;
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_118;
					case 5:
						ArenaPlayerBehavioursEvent._parser = new MessageParser<ArenaPlayerBehavioursEvent>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 6:
						goto IL_130;
					case 7:
						return;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 != 0)
					{
						num2 = 5;
					}
				}
				IL_118:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
				continue;
				IL_130:
				ArenaPlayerBehavioursEvent.BanDurationDefaultValue = 0;
				num = 7;
			}
		}

		// Token: 0x0600958C RID: 38284 RVA: 0x002774A8 File Offset: 0x002756A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qFqSO8JXrTtSIkn5pV56()
		{
			return true;
		}

		// Token: 0x0600958D RID: 38285 RVA: 0x002774B0 File Offset: 0x002756B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ArenaPlayerBehavioursEvent Hq2M6AJXVZCtENh2Ihjc()
		{
			return null;
		}

		// Token: 0x040037AB RID: 14251
		private static readonly MessageParser<ArenaPlayerBehavioursEvent> _parser;

		// Token: 0x040037AC RID: 14252
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037AD RID: 14253
		private int _hasBits0;

		// Token: 0x040037AE RID: 14254
		public const int FlagsFieldNumber = 1;

		// Token: 0x040037AF RID: 14255
		private static readonly FieldCodec<string> _repeated_flags_codec;

		// Token: 0x040037B0 RID: 14256
		private readonly RepeatedField<string> flags_;

		// Token: 0x040037B1 RID: 14257
		public const int SanctionsFieldNumber = 2;

		// Token: 0x040037B2 RID: 14258
		private static readonly FieldCodec<string> _repeated_sanctions_codec;

		// Token: 0x040037B3 RID: 14259
		private readonly RepeatedField<string> sanctions_;

		// Token: 0x040037B4 RID: 14260
		public const int BanDurationFieldNumber = 3;

		// Token: 0x040037B5 RID: 14261
		private static readonly int BanDurationDefaultValue;

		// Token: 0x040037B6 RID: 14262
		private int banDuration_;

		// Token: 0x040037B7 RID: 14263
		internal static ArenaPlayerBehavioursEvent QDkuGRJXhL5PPWCq01jD;
	}
}
