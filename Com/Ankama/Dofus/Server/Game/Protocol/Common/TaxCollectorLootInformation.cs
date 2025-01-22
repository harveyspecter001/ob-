using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B94 RID: 2964
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorLootInformation : IMessage<TaxCollectorLootInformation>, IMessage, IEquatable<TaxCollectorLootInformation>, IDeepCloneable<TaxCollectorLootInformation>, IBufferMessage
	{
		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x06008E55 RID: 36437 RVA: 0x0026B91C File Offset: 0x00269B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorLootInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x06008E56 RID: 36438 RVA: 0x0026B92C File Offset: 0x00269B2C
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

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x06008E57 RID: 36439 RVA: 0x0026B93C File Offset: 0x00269B3C
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

		// Token: 0x06008E58 RID: 36440 RVA: 0x0026B94C File Offset: 0x00269B4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorLootInformation()
		{
		}

		// Token: 0x06008E59 RID: 36441 RVA: 0x0026B95C File Offset: 0x00269B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorLootInformation(TaxCollectorLootInformation other)
		{
		}

		// Token: 0x06008E5A RID: 36442 RVA: 0x0026B96C File Offset: 0x00269B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorLootInformation Clone()
		{
			return null;
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x06008E5B RID: 36443 RVA: 0x0026B97C File Offset: 0x00269B7C
		// (set) Token: 0x06008E5C RID: 36444 RVA: 0x0026B98C File Offset: 0x00269B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Pods
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x06008E5D RID: 36445 RVA: 0x0026B99C File Offset: 0x00269B9C
		// (set) Token: 0x06008E5E RID: 36446 RVA: 0x0026B9AC File Offset: 0x00269BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ItemsKamasValue
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

		// Token: 0x06008E5F RID: 36447 RVA: 0x0026B9BC File Offset: 0x00269BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008E60 RID: 36448 RVA: 0x0026B9CC File Offset: 0x00269BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorLootInformation other)
		{
			return true;
		}

		// Token: 0x06008E61 RID: 36449 RVA: 0x0026B9DC File Offset: 0x00269BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008E62 RID: 36450 RVA: 0x0026B9EC File Offset: 0x00269BEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008E63 RID: 36451 RVA: 0x0026B9FC File Offset: 0x00269BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008E64 RID: 36452 RVA: 0x0026BA0C File Offset: 0x00269C0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008E65 RID: 36453 RVA: 0x0026BA1C File Offset: 0x00269C1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008E66 RID: 36454 RVA: 0x0026BA2C File Offset: 0x00269C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorLootInformation other)
		{
		}

		// Token: 0x06008E67 RID: 36455 RVA: 0x0026BA3C File Offset: 0x00269C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008E68 RID: 36456 RVA: 0x0026BA4C File Offset: 0x00269C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008E69 RID: 36457 RVA: 0x0026BA5C File Offset: 0x00269C5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorLootInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					TaxCollectorLootInformation._parser = new MessageParser<TaxCollectorLootInformation>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06008E6A RID: 36458 RVA: 0x0026BB54 File Offset: 0x00269D54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Eh06TQJ9T8AWoIXWWyPQ()
		{
			return true;
		}

		// Token: 0x06008E6B RID: 36459 RVA: 0x0026BB5C File Offset: 0x00269D5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorLootInformation P8cfGIJ9pgRJEQaIZ9hl()
		{
			return null;
		}

		// Token: 0x040034D7 RID: 13527
		private static readonly MessageParser<TaxCollectorLootInformation> _parser;

		// Token: 0x040034D8 RID: 13528
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034D9 RID: 13529
		public const int PodsFieldNumber = 1;

		// Token: 0x040034DA RID: 13530
		private int pods_;

		// Token: 0x040034DB RID: 13531
		public const int ItemsKamasValueFieldNumber = 2;

		// Token: 0x040034DC RID: 13532
		private long itemsKamasValue_;

		// Token: 0x040034DD RID: 13533
		private static TaxCollectorLootInformation Hj386xJ97sdKjTxGD4Ko;
	}
}
