using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x0200042D RID: 1069
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MultiTabStorageEvent : IMessage<MultiTabStorageEvent>, IMessage, IEquatable<MultiTabStorageEvent>, IDeepCloneable<MultiTabStorageEvent>, IBufferMessage
	{
		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x060032B0 RID: 12976 RVA: 0x001D6A04 File Offset: 0x001D4C04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MultiTabStorageEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x060032B1 RID: 12977 RVA: 0x001D6A14 File Offset: 0x001D4C14
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

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x060032B2 RID: 12978 RVA: 0x001D6A24 File Offset: 0x001D4C24
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

		// Token: 0x060032B3 RID: 12979 RVA: 0x001D6A34 File Offset: 0x001D4C34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MultiTabStorageEvent()
		{
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x001D6A44 File Offset: 0x001D4C44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MultiTabStorageEvent(MultiTabStorageEvent other)
		{
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x001D6A54 File Offset: 0x001D4C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MultiTabStorageEvent Clone()
		{
			return null;
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x001D6A64 File Offset: 0x001D4C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<StorageTab> Tabs
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x001D6A74 File Offset: 0x001D4C74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x001D6A84 File Offset: 0x001D4C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MultiTabStorageEvent other)
		{
			return true;
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x001D6A94 File Offset: 0x001D4C94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x001D6AA4 File Offset: 0x001D4CA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060032BB RID: 12987 RVA: 0x001D6AB4 File Offset: 0x001D4CB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060032BC RID: 12988 RVA: 0x001D6AC4 File Offset: 0x001D4CC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060032BD RID: 12989 RVA: 0x001D6AD4 File Offset: 0x001D4CD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x001D6AE4 File Offset: 0x001D4CE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MultiTabStorageEvent other)
		{
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x001D6AF4 File Offset: 0x001D4CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x001D6B04 File Offset: 0x001D4D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x001D6B14 File Offset: 0x001D4D14
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MultiTabStorageEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					MultiTabStorageEvent._parser = new MessageParser<MultiTabStorageEvent>(() => null);
					num2 = 5;
					continue;
				case 4:
					return;
				case 5:
					MultiTabStorageEvent._repeated_tabs_codec = FieldCodec.ForMessage<StorageTab>(10U, GhhPj3nPGju4Fo3Pf6qS.XVInXhlssT(GhhPj3nPGju4Fo3Pf6qS.onhnPgOPS08));
					num2 = 4;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x001D6C1C File Offset: 0x001D4E1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rl7sssODBBx33CKXrUxQ()
		{
			return true;
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x001D6C24 File Offset: 0x001D4E24
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MultiTabStorageEvent vTeoimODeDeP8EDRlWxM()
		{
			return null;
		}

		// Token: 0x040011BE RID: 4542
		private static readonly MessageParser<MultiTabStorageEvent> _parser;

		// Token: 0x040011BF RID: 4543
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011C0 RID: 4544
		public const int TabsFieldNumber = 1;

		// Token: 0x040011C1 RID: 4545
		private static readonly FieldCodec<StorageTab> _repeated_tabs_codec;

		// Token: 0x040011C2 RID: 4546
		private readonly RepeatedField<StorageTab> tabs_;

		// Token: 0x040011C3 RID: 4547
		private static MultiTabStorageEvent aKKVvZODASNtFKCpRpm3;
	}
}
