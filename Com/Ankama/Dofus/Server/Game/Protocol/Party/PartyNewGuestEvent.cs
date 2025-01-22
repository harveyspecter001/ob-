using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002E2 RID: 738
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyNewGuestEvent : IMessage<PartyNewGuestEvent>, IMessage, IEquatable<PartyNewGuestEvent>, IDeepCloneable<PartyNewGuestEvent>, IBufferMessage
	{
		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06002241 RID: 8769 RVA: 0x001BC44C File Offset: 0x001BA64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyNewGuestEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x001BC45C File Offset: 0x001BA65C
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

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06002243 RID: 8771 RVA: 0x001BC46C File Offset: 0x001BA66C
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

		// Token: 0x06002244 RID: 8772 RVA: 0x001BC47C File Offset: 0x001BA67C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyNewGuestEvent()
		{
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x001BC48C File Offset: 0x001BA68C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyNewGuestEvent(PartyNewGuestEvent other)
		{
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x001BC49C File Offset: 0x001BA69C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyNewGuestEvent Clone()
		{
			return null;
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x001BC4AC File Offset: 0x001BA6AC
		// (set) Token: 0x06002248 RID: 8776 RVA: 0x001BC4BC File Offset: 0x001BA6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PartyId
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

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x001BC4CC File Offset: 0x001BA6CC
		// (set) Token: 0x0600224A RID: 8778 RVA: 0x001BC4DC File Offset: 0x001BA6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartyGuest Guest
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

		// Token: 0x0600224B RID: 8779 RVA: 0x001BC4EC File Offset: 0x001BA6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x001BC4FC File Offset: 0x001BA6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyNewGuestEvent other)
		{
			return true;
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x001BC50C File Offset: 0x001BA70C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x001BC51C File Offset: 0x001BA71C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x001BC52C File Offset: 0x001BA72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x001BC53C File Offset: 0x001BA73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x001BC54C File Offset: 0x001BA74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x001BC55C File Offset: 0x001BA75C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyNewGuestEvent other)
		{
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x001BC56C File Offset: 0x001BA76C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x001BC57C File Offset: 0x001BA77C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x001BC58C File Offset: 0x001BA78C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyNewGuestEvent()
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
					num2 = 4;
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
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				PartyNewGuestEvent._parser = new MessageParser<PartyNewGuestEvent>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x001BC658 File Offset: 0x001BA858
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bSG12bOL3lWVLI5okpJh()
		{
			return true;
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x001BC660 File Offset: 0x001BA860
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyNewGuestEvent JNGNqjOLRtnAqL6RyHs6()
		{
			return null;
		}

		// Token: 0x04000C1B RID: 3099
		private static readonly MessageParser<PartyNewGuestEvent> _parser;

		// Token: 0x04000C1C RID: 3100
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C1D RID: 3101
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000C1E RID: 3102
		private int partyId_;

		// Token: 0x04000C1F RID: 3103
		public const int GuestFieldNumber = 2;

		// Token: 0x04000C20 RID: 3104
		private PartyGuest guest_;

		// Token: 0x04000C21 RID: 3105
		internal static PartyNewGuestEvent WscWdsOLeYBXkWOuG3ik;
	}
}
