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
	// Token: 0x02000405 RID: 1029
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectAddedEvent : IMessage<ObjectAddedEvent>, IMessage, IEquatable<ObjectAddedEvent>, IDeepCloneable<ObjectAddedEvent>, IBufferMessage
	{
		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x0600308B RID: 12427 RVA: 0x001D3E28 File Offset: 0x001D2028
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ObjectAddedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x0600308C RID: 12428 RVA: 0x001D3E38 File Offset: 0x001D2038
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

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x0600308D RID: 12429 RVA: 0x001D3E48 File Offset: 0x001D2048
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

		// Token: 0x0600308E RID: 12430 RVA: 0x001D3E58 File Offset: 0x001D2058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectAddedEvent()
		{
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x001D3E68 File Offset: 0x001D2068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectAddedEvent(ObjectAddedEvent other)
		{
		}

		// Token: 0x06003090 RID: 12432 RVA: 0x001D3E78 File Offset: 0x001D2078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectAddedEvent Clone()
		{
			return null;
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06003091 RID: 12433 RVA: 0x001D3E88 File Offset: 0x001D2088
		// (set) Token: 0x06003092 RID: 12434 RVA: 0x001D3E98 File Offset: 0x001D2098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06003093 RID: 12435 RVA: 0x001D3EA8 File Offset: 0x001D20A8
		// (set) Token: 0x06003094 RID: 12436 RVA: 0x001D3EBC File Offset: 0x001D20BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ObjectOrigin Origin
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ObjectOrigin)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06003095 RID: 12437 RVA: 0x001D3ECC File Offset: 0x001D20CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x001D3EDC File Offset: 0x001D20DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectAddedEvent other)
		{
			return true;
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x001D3EEC File Offset: 0x001D20EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x001D3EFC File Offset: 0x001D20FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x001D3F0C File Offset: 0x001D210C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x001D3F1C File Offset: 0x001D211C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600309B RID: 12443 RVA: 0x001D3F2C File Offset: 0x001D212C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600309C RID: 12444 RVA: 0x001D3F3C File Offset: 0x001D213C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectAddedEvent other)
		{
		}

		// Token: 0x0600309D RID: 12445 RVA: 0x001D3F4C File Offset: 0x001D214C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600309E RID: 12446 RVA: 0x001D3F5C File Offset: 0x001D215C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600309F RID: 12447 RVA: 0x001D3F6C File Offset: 0x001D216C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectAddedEvent()
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
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 3;
						break;
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						goto IL_9B;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 != 0)
						{
							num2 = 2;
						}
						break;
					case 4:
						return;
					}
				}
				IL_9B:
				ObjectAddedEvent._parser = new MessageParser<ObjectAddedEvent>(() => null);
				num = 4;
			}
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x001D403C File Offset: 0x001D223C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nuaM3sOC3Ma5H7Ou8qqx()
		{
			return true;
		}

		// Token: 0x060030A1 RID: 12449 RVA: 0x001D4044 File Offset: 0x001D2244
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectAddedEvent HNBjQ3OCRDUpSomaeXlJ()
		{
			return null;
		}

		// Token: 0x04001107 RID: 4359
		private static readonly MessageParser<ObjectAddedEvent> _parser;

		// Token: 0x04001108 RID: 4360
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001109 RID: 4361
		public const int ObjectFieldNumber = 1;

		// Token: 0x0400110A RID: 4362
		private ObjectItemInventory object_;

		// Token: 0x0400110B RID: 4363
		public const int OriginFieldNumber = 2;

		// Token: 0x0400110C RID: 4364
		private ObjectOrigin origin_;

		// Token: 0x0400110D RID: 4365
		private static ObjectAddedEvent dVKTK4OCefc52LsvoUnZ;
	}
}
