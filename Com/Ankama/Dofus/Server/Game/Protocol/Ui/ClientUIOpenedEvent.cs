using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Ui
{
	// Token: 0x02000030 RID: 48
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClientUIOpenedEvent : IMessage<ClientUIOpenedEvent>, IMessage, IEquatable<ClientUIOpenedEvent>, IDeepCloneable<ClientUIOpenedEvent>, IBufferMessage
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00184F80 File Offset: 0x00183180
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ClientUIOpenedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00184F90 File Offset: 0x00183190
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

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00184FA0 File Offset: 0x001831A0
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

		// Token: 0x060001C4 RID: 452 RVA: 0x00184FB0 File Offset: 0x001831B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClientUIOpenedEvent()
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00184FC0 File Offset: 0x001831C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClientUIOpenedEvent(ClientUIOpenedEvent other)
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00184FD0 File Offset: 0x001831D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClientUIOpenedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00184FE0 File Offset: 0x001831E0
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00184FF4 File Offset: 0x001831F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ClientUIOpenedEvent.Types.UIType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ClientUIOpenedEvent.Types.UIType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00185004 File Offset: 0x00183204
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00185014 File Offset: 0x00183214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectUid
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

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00185024 File Offset: 0x00183224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasObjectUid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00185034 File Offset: 0x00183234
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearObjectUid()
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00185044 File Offset: 0x00183244
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00185054 File Offset: 0x00183254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ClientUIOpenedEvent other)
		{
			return true;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00185064 File Offset: 0x00183264
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00185074 File Offset: 0x00183274
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00185084 File Offset: 0x00183284
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00185094 File Offset: 0x00183294
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x001850A4 File Offset: 0x001832A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x001850B4 File Offset: 0x001832B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ClientUIOpenedEvent other)
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x001850C4 File Offset: 0x001832C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x001850D4 File Offset: 0x001832D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x001850E4 File Offset: 0x001832E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ClientUIOpenedEvent()
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
						goto IL_8B;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 5:
						ClientUIOpenedEvent._parser = new MessageParser<ClientUIOpenedEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					ClientUIOpenedEvent.ObjectUidDefaultValue = 0;
					num2 = 3;
				}
				IL_8B:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x001851E0 File Offset: 0x001833E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LsVWrrOjEfn9pNQjot33()
		{
			return true;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x001851E8 File Offset: 0x001833E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ClientUIOpenedEvent sFvOuLOjXi09DRDhDQIK()
		{
			return null;
		}

		// Token: 0x040000B8 RID: 184
		private static readonly MessageParser<ClientUIOpenedEvent> _parser;

		// Token: 0x040000B9 RID: 185
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000BA RID: 186
		private int _hasBits0;

		// Token: 0x040000BB RID: 187
		public const int TypeFieldNumber = 1;

		// Token: 0x040000BC RID: 188
		private ClientUIOpenedEvent.Types.UIType type_;

		// Token: 0x040000BD RID: 189
		public const int ObjectUidFieldNumber = 2;

		// Token: 0x040000BE RID: 190
		private static readonly int ObjectUidDefaultValue;

		// Token: 0x040000BF RID: 191
		private int objectUid_;

		// Token: 0x040000C0 RID: 192
		private static ClientUIOpenedEvent FLelUNOj2iq8SKgAnC3Q;

		// Token: 0x02000031 RID: 49
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x060001DA RID: 474 RVA: 0x002A5C34 File Offset: 0x002A3E34
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000032 RID: 50
			public enum UIType
			{
				// Token: 0x040000C2 RID: 194
				[OriginalName("UNDEFINED")]
				Undefined,
				// Token: 0x040000C3 RID: 195
				[OriginalName("TELEPORT_GUILD_HOUSE")]
				TeleportGuildHouse,
				// Token: 0x040000C4 RID: 196
				[OriginalName("TELEPORT_GUILD_PADDOCK")]
				TeleportGuildPaddock,
				// Token: 0x040000C5 RID: 197
				[OriginalName("OBJECT_MIMICRY")]
				ObjectMimicry,
				// Token: 0x040000C6 RID: 198
				[OriginalName("LEGENDARY_TREASURE_QUEST")]
				LegendaryTreasureQuest,
				// Token: 0x040000C7 RID: 199
				[OriginalName("TELEPORT_HOUSE")]
				TeleportHouse
			}
		}
	}
}
