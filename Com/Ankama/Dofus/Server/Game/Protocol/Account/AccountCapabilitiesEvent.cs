using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Account
{
	// Token: 0x02000DE4 RID: 3556
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AccountCapabilitiesEvent : IMessage<AccountCapabilitiesEvent>, IMessage, IEquatable<AccountCapabilitiesEvent>, IDeepCloneable<AccountCapabilitiesEvent>, IBufferMessage
	{
		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x0600AB54 RID: 43860 RVA: 0x0029A418 File Offset: 0x00298618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AccountCapabilitiesEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x0600AB55 RID: 43861 RVA: 0x0029A428 File Offset: 0x00298628
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

		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x0600AB56 RID: 43862 RVA: 0x0029A438 File Offset: 0x00298638
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

		// Token: 0x0600AB57 RID: 43863 RVA: 0x0029A448 File Offset: 0x00298648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountCapabilitiesEvent()
		{
		}

		// Token: 0x0600AB58 RID: 43864 RVA: 0x0029A458 File Offset: 0x00298658
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountCapabilitiesEvent(AccountCapabilitiesEvent other)
		{
		}

		// Token: 0x0600AB59 RID: 43865 RVA: 0x0029A468 File Offset: 0x00298668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountCapabilitiesEvent Clone()
		{
			return null;
		}

		// Token: 0x17001FBF RID: 8127
		// (get) Token: 0x0600AB5A RID: 43866 RVA: 0x0029A478 File Offset: 0x00298678
		// (set) Token: 0x0600AB5B RID: 43867 RVA: 0x0029A488 File Offset: 0x00298688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AccountId
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

		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x0600AB5C RID: 43868 RVA: 0x0029A498 File Offset: 0x00298698
		// (set) Token: 0x0600AB5D RID: 43869 RVA: 0x0029A4A8 File Offset: 0x002986A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool TutorialAvailable
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

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x0600AB5E RID: 43870 RVA: 0x0029A4B8 File Offset: 0x002986B8
		// (set) Token: 0x0600AB5F RID: 43871 RVA: 0x0029A4CC File Offset: 0x002986CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Hierarchy Status
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Hierarchy)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x0600AB60 RID: 43872 RVA: 0x0029A4DC File Offset: 0x002986DC
		// (set) Token: 0x0600AB61 RID: 43873 RVA: 0x0029A4EC File Offset: 0x002986EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanCreateNewCharacter
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

		// Token: 0x0600AB62 RID: 43874 RVA: 0x0029A4FC File Offset: 0x002986FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AB63 RID: 43875 RVA: 0x0029A50C File Offset: 0x0029870C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AccountCapabilitiesEvent other)
		{
			return true;
		}

		// Token: 0x0600AB64 RID: 43876 RVA: 0x0029A51C File Offset: 0x0029871C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AB65 RID: 43877 RVA: 0x0029A52C File Offset: 0x0029872C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AB66 RID: 43878 RVA: 0x0029A53C File Offset: 0x0029873C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AB67 RID: 43879 RVA: 0x0029A54C File Offset: 0x0029874C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AB68 RID: 43880 RVA: 0x0029A55C File Offset: 0x0029875C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AB69 RID: 43881 RVA: 0x0029A56C File Offset: 0x0029876C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AccountCapabilitiesEvent other)
		{
		}

		// Token: 0x0600AB6A RID: 43882 RVA: 0x0029A57C File Offset: 0x0029877C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AB6B RID: 43883 RVA: 0x0029A58C File Offset: 0x0029878C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AB6C RID: 43884 RVA: 0x0029A59C File Offset: 0x0029879C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AccountCapabilitiesEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AccountCapabilitiesEvent._parser = new MessageParser<AccountCapabilitiesEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x0600AB6D RID: 43885 RVA: 0x0029A668 File Offset: 0x00298868
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Lb5oHOJUfohcQT4SsSWt()
		{
			return true;
		}

		// Token: 0x0600AB6E RID: 43886 RVA: 0x0029A670 File Offset: 0x00298870
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AccountCapabilitiesEvent Yer5QUJUn5uRshIWUq8A()
		{
			return null;
		}

		// Token: 0x04003EDF RID: 16095
		private static readonly MessageParser<AccountCapabilitiesEvent> _parser;

		// Token: 0x04003EE0 RID: 16096
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EE1 RID: 16097
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04003EE2 RID: 16098
		private long accountId_;

		// Token: 0x04003EE3 RID: 16099
		public const int TutorialAvailableFieldNumber = 2;

		// Token: 0x04003EE4 RID: 16100
		private bool tutorialAvailable_;

		// Token: 0x04003EE5 RID: 16101
		public const int StatusFieldNumber = 3;

		// Token: 0x04003EE6 RID: 16102
		private Hierarchy status_;

		// Token: 0x04003EE7 RID: 16103
		public const int CanCreateNewCharacterFieldNumber = 4;

		// Token: 0x04003EE8 RID: 16104
		private bool canCreateNewCharacter_;

		// Token: 0x04003EE9 RID: 16105
		private static AccountCapabilitiesEvent pEqGNgJczeUglaTFLw8A;
	}
}
