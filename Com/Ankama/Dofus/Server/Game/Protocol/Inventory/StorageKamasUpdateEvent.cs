using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x02000431 RID: 1073
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StorageKamasUpdateEvent : IMessage<StorageKamasUpdateEvent>, IMessage, IEquatable<StorageKamasUpdateEvent>, IDeepCloneable<StorageKamasUpdateEvent>, IBufferMessage
	{
		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x060032E4 RID: 13028 RVA: 0x001D6E74 File Offset: 0x001D5074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StorageKamasUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x060032E5 RID: 13029 RVA: 0x001D6E84 File Offset: 0x001D5084
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

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x060032E6 RID: 13030 RVA: 0x001D6E94 File Offset: 0x001D5094
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

		// Token: 0x060032E7 RID: 13031 RVA: 0x001D6EA4 File Offset: 0x001D50A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageKamasUpdateEvent()
		{
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x001D6EB4 File Offset: 0x001D50B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageKamasUpdateEvent(StorageKamasUpdateEvent other)
		{
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x001D6EC4 File Offset: 0x001D50C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageKamasUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x060032EA RID: 13034 RVA: 0x001D6ED4 File Offset: 0x001D50D4
		// (set) Token: 0x060032EB RID: 13035 RVA: 0x001D6EE4 File Offset: 0x001D50E4
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

		// Token: 0x060032EC RID: 13036 RVA: 0x001D6EF4 File Offset: 0x001D50F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x001D6F04 File Offset: 0x001D5104
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(StorageKamasUpdateEvent other)
		{
			return true;
		}

		// Token: 0x060032EE RID: 13038 RVA: 0x001D6F14 File Offset: 0x001D5114
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x001D6F24 File Offset: 0x001D5124
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060032F0 RID: 13040 RVA: 0x001D6F34 File Offset: 0x001D5134
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x001D6F44 File Offset: 0x001D5144
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x001D6F54 File Offset: 0x001D5154
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x001D6F64 File Offset: 0x001D5164
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(StorageKamasUpdateEvent other)
		{
		}

		// Token: 0x060032F4 RID: 13044 RVA: 0x001D6F74 File Offset: 0x001D5174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x001D6F84 File Offset: 0x001D5184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060032F6 RID: 13046 RVA: 0x001D6F94 File Offset: 0x001D5194
		[MethodImpl(MethodImplOptions.NoInlining)]
		static StorageKamasUpdateEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					StorageKamasUpdateEvent._parser = new MessageParser<StorageKamasUpdateEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x001D7078 File Offset: 0x001D5278
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Y4s3SZODGP1QRSMcltUm()
		{
			return true;
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x001D7080 File Offset: 0x001D5280
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static StorageKamasUpdateEvent FuZv2lODguPAg7YN9h7y()
		{
			return null;
		}

		// Token: 0x040011D0 RID: 4560
		private static readonly MessageParser<StorageKamasUpdateEvent> _parser;

		// Token: 0x040011D1 RID: 4561
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011D2 RID: 4562
		public const int KamasFieldNumber = 1;

		// Token: 0x040011D3 RID: 4563
		private long kamas_;

		// Token: 0x040011D4 RID: 4564
		private static StorageKamasUpdateEvent R2JUmpODJ3ieV3u07NDM;
	}
}
