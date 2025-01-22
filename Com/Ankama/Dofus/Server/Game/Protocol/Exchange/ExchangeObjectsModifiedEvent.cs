using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200071D RID: 1821
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectsModifiedEvent : IMessage<ExchangeObjectsModifiedEvent>, IMessage, IEquatable<ExchangeObjectsModifiedEvent>, IDeepCloneable<ExchangeObjectsModifiedEvent>, IBufferMessage
	{
		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06005923 RID: 22819 RVA: 0x00217078 File Offset: 0x00215278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeObjectsModifiedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06005924 RID: 22820 RVA: 0x00217088 File Offset: 0x00215288
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

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06005925 RID: 22821 RVA: 0x00217098 File Offset: 0x00215298
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

		// Token: 0x06005926 RID: 22822 RVA: 0x002170A8 File Offset: 0x002152A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectsModifiedEvent()
		{
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x002170B8 File Offset: 0x002152B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectsModifiedEvent(ExchangeObjectsModifiedEvent other)
		{
		}

		// Token: 0x06005928 RID: 22824 RVA: 0x002170C8 File Offset: 0x002152C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectsModifiedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06005929 RID: 22825 RVA: 0x002170D8 File Offset: 0x002152D8
		// (set) Token: 0x0600592A RID: 22826 RVA: 0x002170E8 File Offset: 0x002152E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Remote
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

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x0600592B RID: 22827 RVA: 0x002170F8 File Offset: 0x002152F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ObjectItemInventory> Objects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x00217108 File Offset: 0x00215308
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600592D RID: 22829 RVA: 0x00217118 File Offset: 0x00215318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectsModifiedEvent other)
		{
			return true;
		}

		// Token: 0x0600592E RID: 22830 RVA: 0x00217128 File Offset: 0x00215328
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600592F RID: 22831 RVA: 0x00217138 File Offset: 0x00215338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005930 RID: 22832 RVA: 0x00217148 File Offset: 0x00215348
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005931 RID: 22833 RVA: 0x00217158 File Offset: 0x00215358
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005932 RID: 22834 RVA: 0x00217168 File Offset: 0x00215368
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005933 RID: 22835 RVA: 0x00217178 File Offset: 0x00215378
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectsModifiedEvent other)
		{
		}

		// Token: 0x06005934 RID: 22836 RVA: 0x00217188 File Offset: 0x00215388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x00217198 File Offset: 0x00215398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005936 RID: 22838 RVA: 0x002171A8 File Offset: 0x002153A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectsModifiedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					ExchangeObjectsModifiedEvent._parser = new MessageParser<ExchangeObjectsModifiedEvent>(() => null);
					num2 = 4;
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					ExchangeObjectsModifiedEvent._repeated_objects_codec = FieldCodec.ForMessage<ObjectItemInventory>(18U, MA8hA9n80ObjtPbmhEGb.XVInXhlssT(MA8hA9n80ObjtPbmhEGb.D4hn8C6OFiy));
					num2 = 5;
					continue;
				case 5:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06005937 RID: 22839 RVA: 0x002172B0 File Offset: 0x002154B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YbcbN2OupZcB3c5aD2Ca()
		{
			return true;
		}

		// Token: 0x06005938 RID: 22840 RVA: 0x002172B8 File Offset: 0x002154B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectsModifiedEvent umaNNEOuHuunJGkkgjlm()
		{
			return null;
		}

		// Token: 0x04001F39 RID: 7993
		private static readonly MessageParser<ExchangeObjectsModifiedEvent> _parser;

		// Token: 0x04001F3A RID: 7994
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F3B RID: 7995
		public const int RemoteFieldNumber = 1;

		// Token: 0x04001F3C RID: 7996
		private bool remote_;

		// Token: 0x04001F3D RID: 7997
		public const int ObjectsFieldNumber = 2;

		// Token: 0x04001F3E RID: 7998
		private static readonly FieldCodec<ObjectItemInventory> _repeated_objects_codec;

		// Token: 0x04001F3F RID: 7999
		private readonly RepeatedField<ObjectItemInventory> objects_;

		// Token: 0x04001F40 RID: 8000
		internal static ExchangeObjectsModifiedEvent oFUqdWOuT2LLdcE3afs2;
	}
}
