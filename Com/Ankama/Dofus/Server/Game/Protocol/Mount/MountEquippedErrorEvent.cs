using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x02000385 RID: 901
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountEquippedErrorEvent : IMessage<MountEquippedErrorEvent>, IMessage, IEquatable<MountEquippedErrorEvent>, IDeepCloneable<MountEquippedErrorEvent>, IBufferMessage
	{
		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06002A42 RID: 10818 RVA: 0x001C8C58 File Offset: 0x001C6E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MountEquippedErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06002A43 RID: 10819 RVA: 0x001C8C68 File Offset: 0x001C6E68
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

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06002A44 RID: 10820 RVA: 0x001C8C78 File Offset: 0x001C6E78
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

		// Token: 0x06002A45 RID: 10821 RVA: 0x001C8C88 File Offset: 0x001C6E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountEquippedErrorEvent()
		{
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x001C8C98 File Offset: 0x001C6E98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountEquippedErrorEvent(MountEquippedErrorEvent other)
		{
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x001C8CA8 File Offset: 0x001C6EA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountEquippedErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06002A48 RID: 10824 RVA: 0x001C8CB8 File Offset: 0x001C6EB8
		// (set) Token: 0x06002A49 RID: 10825 RVA: 0x001C8CCC File Offset: 0x001C6ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MountEquippedErrorEvent.Types.MountEquippedError Error
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (MountEquippedErrorEvent.Types.MountEquippedError)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x001C8CDC File Offset: 0x001C6EDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x001C8CEC File Offset: 0x001C6EEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountEquippedErrorEvent other)
		{
			return true;
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x001C8CFC File Offset: 0x001C6EFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x001C8D0C File Offset: 0x001C6F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x001C8D1C File Offset: 0x001C6F1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x001C8D2C File Offset: 0x001C6F2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x001C8D3C File Offset: 0x001C6F3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x001C8D4C File Offset: 0x001C6F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountEquippedErrorEvent other)
		{
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x001C8D5C File Offset: 0x001C6F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x001C8D6C File Offset: 0x001C6F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x001C8D7C File Offset: 0x001C6F7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountEquippedErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_35;
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						MountEquippedErrorEvent._parser = new MessageParser<MountEquippedErrorEvent>(() => null);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						return;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
						{
							num2 = 1;
						}
						break;
					}
				}
				IL_35:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x001C8E64 File Offset: 0x001C7064
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aOaWr6OrycP3xqe0lfmL()
		{
			return true;
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x001C8E6C File Offset: 0x001C706C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountEquippedErrorEvent D4ssILOr6G3jWS5SpyZq()
		{
			return null;
		}

		// Token: 0x04000EE9 RID: 3817
		private static readonly MessageParser<MountEquippedErrorEvent> _parser;

		// Token: 0x04000EEA RID: 3818
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EEB RID: 3819
		public const int ErrorFieldNumber = 1;

		// Token: 0x04000EEC RID: 3820
		private MountEquippedErrorEvent.Types.MountEquippedError error_;

		// Token: 0x04000EED RID: 3821
		private static MountEquippedErrorEvent pHB6oJOr5xH2jrqdH3cQ;

		// Token: 0x02000386 RID: 902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06002A57 RID: 10839 RVA: 0x002B9944 File Offset: 0x002B7B44
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000387 RID: 903
			public enum MountEquippedError
			{
				// Token: 0x04000EEF RID: 3823
				[OriginalName("UNEQUIPPED")]
				Unequipped,
				// Token: 0x04000EF0 RID: 3824
				[OriginalName("EQUIPPED")]
				Equipped,
				// Token: 0x04000EF1 RID: 3825
				[OriginalName("RIDING")]
				Riding
			}
		}
	}
}
