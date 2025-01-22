using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x02000929 RID: 2345
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterDeletionErrorEvent : IMessage<CharacterDeletionErrorEvent>, IMessage, IEquatable<CharacterDeletionErrorEvent>, IDeepCloneable<CharacterDeletionErrorEvent>, IBufferMessage
	{
		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x060071B7 RID: 29111 RVA: 0x0023CDDC File Offset: 0x0023AFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterDeletionErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x060071B8 RID: 29112 RVA: 0x0023CDEC File Offset: 0x0023AFEC
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

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x060071B9 RID: 29113 RVA: 0x0023CDFC File Offset: 0x0023AFFC
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

		// Token: 0x060071BA RID: 29114 RVA: 0x0023CE0C File Offset: 0x0023B00C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterDeletionErrorEvent()
		{
		}

		// Token: 0x060071BB RID: 29115 RVA: 0x0023CE1C File Offset: 0x0023B01C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterDeletionErrorEvent(CharacterDeletionErrorEvent other)
		{
		}

		// Token: 0x060071BC RID: 29116 RVA: 0x0023CE2C File Offset: 0x0023B02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterDeletionErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x060071BD RID: 29117 RVA: 0x0023CE3C File Offset: 0x0023B03C
		// (set) Token: 0x060071BE RID: 29118 RVA: 0x0023CE50 File Offset: 0x0023B050
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterDeletionErrorEvent.Types.CharacterDeletionError Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CharacterDeletionErrorEvent.Types.CharacterDeletionError)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060071BF RID: 29119 RVA: 0x0023CE60 File Offset: 0x0023B060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060071C0 RID: 29120 RVA: 0x0023CE70 File Offset: 0x0023B070
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterDeletionErrorEvent other)
		{
			return true;
		}

		// Token: 0x060071C1 RID: 29121 RVA: 0x0023CE80 File Offset: 0x0023B080
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060071C2 RID: 29122 RVA: 0x0023CE90 File Offset: 0x0023B090
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060071C3 RID: 29123 RVA: 0x0023CEA0 File Offset: 0x0023B0A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060071C4 RID: 29124 RVA: 0x0023CEB0 File Offset: 0x0023B0B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060071C5 RID: 29125 RVA: 0x0023CEC0 File Offset: 0x0023B0C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060071C6 RID: 29126 RVA: 0x0023CED0 File Offset: 0x0023B0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterDeletionErrorEvent other)
		{
		}

		// Token: 0x060071C7 RID: 29127 RVA: 0x0023CEE0 File Offset: 0x0023B0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060071C8 RID: 29128 RVA: 0x0023CEF0 File Offset: 0x0023B0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060071C9 RID: 29129 RVA: 0x0023CF00 File Offset: 0x0023B100
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterDeletionErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				case 2:
					CharacterDeletionErrorEvent._parser = new MessageParser<CharacterDeletionErrorEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x060071CA RID: 29130 RVA: 0x0023CFCC File Offset: 0x0023B1CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WQUTB7JeCEiKo0WHEl6F()
		{
			return true;
		}

		// Token: 0x060071CB RID: 29131 RVA: 0x0023CFD4 File Offset: 0x0023B1D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterDeletionErrorEvent Tjj58KJeD7WsHyELVQdW()
		{
			return null;
		}

		// Token: 0x040027CF RID: 10191
		private static readonly MessageParser<CharacterDeletionErrorEvent> _parser;

		// Token: 0x040027D0 RID: 10192
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027D1 RID: 10193
		public const int ReasonFieldNumber = 1;

		// Token: 0x040027D2 RID: 10194
		private CharacterDeletionErrorEvent.Types.CharacterDeletionError reason_;

		// Token: 0x040027D3 RID: 10195
		private static CharacterDeletionErrorEvent mlmtYLJe0MpZ5cnKDv8K;

		// Token: 0x0200092A RID: 2346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060071CC RID: 29132 RVA: 0x002DBA34 File Offset: 0x002D9C34
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200092B RID: 2347
			public enum CharacterDeletionError
			{
				// Token: 0x040027D5 RID: 10197
				[OriginalName("DELETE_ERROR_NO_REASON")]
				DeleteErrorNoReason,
				// Token: 0x040027D6 RID: 10198
				[OriginalName("DELETE_ERROR_TOO_MANY_CHAR_DELETED")]
				DeleteErrorTooManyCharDeleted,
				// Token: 0x040027D7 RID: 10199
				[OriginalName("DELETE_ERROR_BAD_SECRET_ANSWER")]
				DeleteErrorBadSecretAnswer
			}
		}
	}
}
