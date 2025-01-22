using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Account
{
	// Token: 0x02000DE6 RID: 3558
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AccountAdditionalFacesEvent : IMessage<AccountAdditionalFacesEvent>, IMessage, IEquatable<AccountAdditionalFacesEvent>, IDeepCloneable<AccountAdditionalFacesEvent>, IBufferMessage
	{
		// Token: 0x17001FC3 RID: 8131
		// (get) Token: 0x0600AB74 RID: 43892 RVA: 0x0029A678 File Offset: 0x00298878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AccountAdditionalFacesEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x0600AB75 RID: 43893 RVA: 0x0029A688 File Offset: 0x00298888
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

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x0600AB76 RID: 43894 RVA: 0x0029A698 File Offset: 0x00298898
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

		// Token: 0x0600AB77 RID: 43895 RVA: 0x0029A6A8 File Offset: 0x002988A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountAdditionalFacesEvent()
		{
		}

		// Token: 0x0600AB78 RID: 43896 RVA: 0x0029A6B8 File Offset: 0x002988B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountAdditionalFacesEvent(AccountAdditionalFacesEvent other)
		{
		}

		// Token: 0x0600AB79 RID: 43897 RVA: 0x0029A6C8 File Offset: 0x002988C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountAdditionalFacesEvent Clone()
		{
			return null;
		}

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x0600AB7A RID: 43898 RVA: 0x0029A6D8 File Offset: 0x002988D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> Faces
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AB7B RID: 43899 RVA: 0x0029A6E8 File Offset: 0x002988E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AB7C RID: 43900 RVA: 0x0029A6F8 File Offset: 0x002988F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AccountAdditionalFacesEvent other)
		{
			return true;
		}

		// Token: 0x0600AB7D RID: 43901 RVA: 0x0029A708 File Offset: 0x00298908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AB7E RID: 43902 RVA: 0x0029A718 File Offset: 0x00298918
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AB7F RID: 43903 RVA: 0x0029A728 File Offset: 0x00298928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AB80 RID: 43904 RVA: 0x0029A738 File Offset: 0x00298938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AB81 RID: 43905 RVA: 0x0029A748 File Offset: 0x00298948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AB82 RID: 43906 RVA: 0x0029A758 File Offset: 0x00298958
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AccountAdditionalFacesEvent other)
		{
		}

		// Token: 0x0600AB83 RID: 43907 RVA: 0x0029A768 File Offset: 0x00298968
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AB84 RID: 43908 RVA: 0x0029A778 File Offset: 0x00298978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AB85 RID: 43909 RVA: 0x0029A788 File Offset: 0x00298988
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AccountAdditionalFacesEvent()
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
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					AccountAdditionalFacesEvent._parser = new MessageParser<AccountAdditionalFacesEvent>(() => null);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				case 5:
					AccountAdditionalFacesEvent._repeated_faces_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600AB86 RID: 43910 RVA: 0x0029A8A0 File Offset: 0x00298AA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JgDGJoJUAafcovpmI0AK()
		{
			return true;
		}

		// Token: 0x0600AB87 RID: 43911 RVA: 0x0029A8A8 File Offset: 0x00298AA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AccountAdditionalFacesEvent Vybw6MJUBsIj8NHcy0Dm()
		{
			return null;
		}

		// Token: 0x04003EEC RID: 16108
		private static readonly MessageParser<AccountAdditionalFacesEvent> _parser;

		// Token: 0x04003EED RID: 16109
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EEE RID: 16110
		public const int FacesFieldNumber = 1;

		// Token: 0x04003EEF RID: 16111
		private static readonly FieldCodec<int> _repeated_faces_codec;

		// Token: 0x04003EF0 RID: 16112
		private readonly RepeatedField<int> faces_;

		// Token: 0x04003EF1 RID: 16113
		private static AccountAdditionalFacesEvent sOgUXuJUmaQeIpdZulyU;
	}
}
