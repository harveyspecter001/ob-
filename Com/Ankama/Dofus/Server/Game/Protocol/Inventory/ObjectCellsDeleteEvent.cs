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
	// Token: 0x02000401 RID: 1025
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectCellsDeleteEvent : IMessage<ObjectCellsDeleteEvent>, IMessage, IEquatable<ObjectCellsDeleteEvent>, IDeepCloneable<ObjectCellsDeleteEvent>, IBufferMessage
	{
		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06003056 RID: 12374 RVA: 0x001D39B8 File Offset: 0x001D1BB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ObjectCellsDeleteEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06003057 RID: 12375 RVA: 0x001D39C8 File Offset: 0x001D1BC8
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

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06003058 RID: 12376 RVA: 0x001D39D8 File Offset: 0x001D1BD8
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

		// Token: 0x06003059 RID: 12377 RVA: 0x001D39E8 File Offset: 0x001D1BE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectCellsDeleteEvent()
		{
		}

		// Token: 0x0600305A RID: 12378 RVA: 0x001D39F8 File Offset: 0x001D1BF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectCellsDeleteEvent(ObjectCellsDeleteEvent other)
		{
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x001D3A08 File Offset: 0x001D1C08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectCellsDeleteEvent Clone()
		{
			return null;
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x0600305C RID: 12380 RVA: 0x001D3A18 File Offset: 0x001D1C18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> CellsId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x001D3A28 File Offset: 0x001D1C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x001D3A38 File Offset: 0x001D1C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectCellsDeleteEvent other)
		{
			return true;
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x001D3A48 File Offset: 0x001D1C48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x001D3A58 File Offset: 0x001D1C58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x001D3A68 File Offset: 0x001D1C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003062 RID: 12386 RVA: 0x001D3A78 File Offset: 0x001D1C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x001D3A88 File Offset: 0x001D1C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x001D3A98 File Offset: 0x001D1C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectCellsDeleteEvent other)
		{
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x001D3AA8 File Offset: 0x001D1CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x001D3AB8 File Offset: 0x001D1CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x001D3AC8 File Offset: 0x001D1CC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectCellsDeleteEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						ObjectCellsDeleteEvent._repeated_cellsId_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						ObjectCellsDeleteEvent._parser = new MessageParser<ObjectCellsDeleteEvent>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				}
				IL_C5:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 3;
				continue;
				goto IL_C5;
			}
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x001D3BE4 File Offset: 0x001D1DE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lfR1jDOCflU3coYcDQRO()
		{
			return true;
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x001D3BEC File Offset: 0x001D1DEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectCellsDeleteEvent n3mOmbOCniyq5xd5NEys()
		{
			return null;
		}

		// Token: 0x040010F6 RID: 4342
		private static readonly MessageParser<ObjectCellsDeleteEvent> _parser;

		// Token: 0x040010F7 RID: 4343
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010F8 RID: 4344
		public const int CellsIdFieldNumber = 1;

		// Token: 0x040010F9 RID: 4345
		private static readonly FieldCodec<int> _repeated_cellsId_codec;

		// Token: 0x040010FA RID: 4346
		private readonly RepeatedField<int> cellsId_;

		// Token: 0x040010FB RID: 4347
		internal static ObjectCellsDeleteEvent fQTBfWO0zKot6PXQ9usL;
	}
}
