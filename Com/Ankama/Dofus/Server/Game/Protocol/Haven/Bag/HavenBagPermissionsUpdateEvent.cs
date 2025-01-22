using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x020004A3 RID: 1187
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagPermissionsUpdateEvent : IMessage<HavenBagPermissionsUpdateEvent>, IMessage, IEquatable<HavenBagPermissionsUpdateEvent>, IDeepCloneable<HavenBagPermissionsUpdateEvent>, IBufferMessage
	{
		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x060038B5 RID: 14517 RVA: 0x001E0C3C File Offset: 0x001DEE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HavenBagPermissionsUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x060038B6 RID: 14518 RVA: 0x001E0C4C File Offset: 0x001DEE4C
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

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x060038B7 RID: 14519 RVA: 0x001E0C5C File Offset: 0x001DEE5C
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

		// Token: 0x060038B8 RID: 14520 RVA: 0x001E0C6C File Offset: 0x001DEE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagPermissionsUpdateEvent()
		{
		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x001E0C7C File Offset: 0x001DEE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagPermissionsUpdateEvent(HavenBagPermissionsUpdateEvent other)
		{
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x001E0C8C File Offset: 0x001DEE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagPermissionsUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x060038BB RID: 14523 RVA: 0x001E0C9C File Offset: 0x001DEE9C
		// (set) Token: 0x060038BC RID: 14524 RVA: 0x001E0CAC File Offset: 0x001DEEAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Permissions
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

		// Token: 0x060038BD RID: 14525 RVA: 0x001E0CBC File Offset: 0x001DEEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x001E0CCC File Offset: 0x001DEECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagPermissionsUpdateEvent other)
		{
			return true;
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x001E0CDC File Offset: 0x001DEEDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x001E0CEC File Offset: 0x001DEEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x001E0CFC File Offset: 0x001DEEFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x001E0D0C File Offset: 0x001DEF0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x001E0D1C File Offset: 0x001DEF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x001E0D2C File Offset: 0x001DEF2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagPermissionsUpdateEvent other)
		{
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x001E0D3C File Offset: 0x001DEF3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060038C6 RID: 14534 RVA: 0x001E0D4C File Offset: 0x001DEF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x001E0D5C File Offset: 0x001DEF5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagPermissionsUpdateEvent()
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
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 4:
					HavenBagPermissionsUpdateEvent._parser = new MessageParser<HavenBagPermissionsUpdateEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x001E0E40 File Offset: 0x001DF040
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tuC0wtOwpK0KB4ShXV8F()
		{
			return true;
		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x001E0E48 File Offset: 0x001DF048
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagPermissionsUpdateEvent F2PPCVOwHAq5n8ZuTW7N()
		{
			return null;
		}

		// Token: 0x040013CC RID: 5068
		private static readonly MessageParser<HavenBagPermissionsUpdateEvent> _parser;

		// Token: 0x040013CD RID: 5069
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013CE RID: 5070
		public const int PermissionsFieldNumber = 1;

		// Token: 0x040013CF RID: 5071
		private int permissions_;

		// Token: 0x040013D0 RID: 5072
		internal static HavenBagPermissionsUpdateEvent rBpN3EOwTl5mWF6WLC8m;
	}
}
