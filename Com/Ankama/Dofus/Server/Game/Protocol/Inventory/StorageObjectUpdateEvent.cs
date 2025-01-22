using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x02000433 RID: 1075
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StorageObjectUpdateEvent : IMessage<StorageObjectUpdateEvent>, IMessage, IEquatable<StorageObjectUpdateEvent>, IDeepCloneable<StorageObjectUpdateEvent>, IBufferMessage
	{
		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x060032FE RID: 13054 RVA: 0x001D7088 File Offset: 0x001D5288
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<StorageObjectUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x060032FF RID: 13055 RVA: 0x001D7098 File Offset: 0x001D5298
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

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06003300 RID: 13056 RVA: 0x001D70A8 File Offset: 0x001D52A8
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

		// Token: 0x06003301 RID: 13057 RVA: 0x001D70B8 File Offset: 0x001D52B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageObjectUpdateEvent()
		{
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x001D70C8 File Offset: 0x001D52C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageObjectUpdateEvent(StorageObjectUpdateEvent other)
		{
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x001D70D8 File Offset: 0x001D52D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageObjectUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06003304 RID: 13060 RVA: 0x001D70E8 File Offset: 0x001D52E8
		// (set) Token: 0x06003305 RID: 13061 RVA: 0x001D70F8 File Offset: 0x001D52F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ObjectItemInventory Object
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

		// Token: 0x06003306 RID: 13062 RVA: 0x001D7108 File Offset: 0x001D5308
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x001D7118 File Offset: 0x001D5318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(StorageObjectUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x001D7128 File Offset: 0x001D5328
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x001D7138 File Offset: 0x001D5338
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x001D7148 File Offset: 0x001D5348
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x001D7158 File Offset: 0x001D5358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x001D7168 File Offset: 0x001D5368
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x001D7178 File Offset: 0x001D5378
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(StorageObjectUpdateEvent other)
		{
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x001D7188 File Offset: 0x001D5388
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x001D7198 File Offset: 0x001D5398
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x001D71A8 File Offset: 0x001D53A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static StorageObjectUpdateEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 3:
					return;
				case 4:
					StorageObjectUpdateEvent._parser = new MessageParser<StorageObjectUpdateEvent>(() => null);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x001D7274 File Offset: 0x001D5474
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LCN3d4ODdWSMZWg6f5Lk()
		{
			return true;
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x001D727C File Offset: 0x001D547C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static StorageObjectUpdateEvent oZnfx4OD9Ce0wY78UBUu()
		{
			return null;
		}

		// Token: 0x040011D7 RID: 4567
		private static readonly MessageParser<StorageObjectUpdateEvent> _parser;

		// Token: 0x040011D8 RID: 4568
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011D9 RID: 4569
		public const int ObjectFieldNumber = 1;

		// Token: 0x040011DA RID: 4570
		private ObjectItemInventory object_;

		// Token: 0x040011DB RID: 4571
		private static StorageObjectUpdateEvent MhtIMvODseVOj4gBSMHq;
	}
}
