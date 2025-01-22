using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x0200042F RID: 1071
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StorageInventoryContentEvent : IMessage<StorageInventoryContentEvent>, IMessage, IEquatable<StorageInventoryContentEvent>, IDeepCloneable<StorageInventoryContentEvent>, IBufferMessage
	{
		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x060032C9 RID: 13001 RVA: 0x001D6C2C File Offset: 0x001D4E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StorageInventoryContentEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x060032CA RID: 13002 RVA: 0x001D6C3C File Offset: 0x001D4E3C
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

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x060032CB RID: 13003 RVA: 0x001D6C4C File Offset: 0x001D4E4C
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

		// Token: 0x060032CC RID: 13004 RVA: 0x001D6C5C File Offset: 0x001D4E5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageInventoryContentEvent()
		{
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x001D6C6C File Offset: 0x001D4E6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageInventoryContentEvent(StorageInventoryContentEvent other)
		{
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x001D6C7C File Offset: 0x001D4E7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageInventoryContentEvent Clone()
		{
			return null;
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x060032CF RID: 13007 RVA: 0x001D6C8C File Offset: 0x001D4E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectItemInventory> Objects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x060032D0 RID: 13008 RVA: 0x001D6C9C File Offset: 0x001D4E9C
		// (set) Token: 0x060032D1 RID: 13009 RVA: 0x001D6CAC File Offset: 0x001D4EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Kamas
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

		// Token: 0x060032D2 RID: 13010 RVA: 0x001D6CBC File Offset: 0x001D4EBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x001D6CCC File Offset: 0x001D4ECC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(StorageInventoryContentEvent other)
		{
			return true;
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x001D6CDC File Offset: 0x001D4EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x001D6CEC File Offset: 0x001D4EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x001D6CFC File Offset: 0x001D4EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x001D6D0C File Offset: 0x001D4F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x001D6D1C File Offset: 0x001D4F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x001D6D2C File Offset: 0x001D4F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(StorageInventoryContentEvent other)
		{
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x001D6D3C File Offset: 0x001D4F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x001D6D4C File Offset: 0x001D4F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x001D6D5C File Offset: 0x001D4F5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static StorageInventoryContentEvent()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					StorageInventoryContentEvent._repeated_objects_codec = FieldCodec.ForMessage<ObjectItemInventory>(10U, MA8hA9n80ObjtPbmhEGb.XVInXhlssT(MA8hA9n80ObjtPbmhEGb.D4hn8C6OFiy));
					num2 = 5;
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
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
					return;
				}
				StorageInventoryContentEvent._parser = new MessageParser<StorageInventoryContentEvent>(() => null);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x001D6E64 File Offset: 0x001D5064
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool l0AKxvODR0FRkvrbT3op()
		{
			return true;
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x001D6E6C File Offset: 0x001D506C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static StorageInventoryContentEvent CmNI7pODOW050BMXlffB()
		{
			return null;
		}

		// Token: 0x040011C6 RID: 4550
		private static readonly MessageParser<StorageInventoryContentEvent> _parser;

		// Token: 0x040011C7 RID: 4551
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011C8 RID: 4552
		public const int ObjectsFieldNumber = 1;

		// Token: 0x040011C9 RID: 4553
		private static readonly FieldCodec<ObjectItemInventory> _repeated_objects_codec;

		// Token: 0x040011CA RID: 4554
		private readonly RepeatedField<ObjectItemInventory> objects_;

		// Token: 0x040011CB RID: 4555
		public const int KamasFieldNumber = 2;

		// Token: 0x040011CC RID: 4556
		private long kamas_;

		// Token: 0x040011CD RID: 4557
		private static StorageInventoryContentEvent hOOiq3OD3AixfwrI4V30;
	}
}
