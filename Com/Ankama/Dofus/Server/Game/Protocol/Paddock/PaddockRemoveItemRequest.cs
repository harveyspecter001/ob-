using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock
{
	// Token: 0x0200030B RID: 779
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PaddockRemoveItemRequest : IMessage<PaddockRemoveItemRequest>, IMessage, IEquatable<PaddockRemoveItemRequest>, IDeepCloneable<PaddockRemoveItemRequest>, IBufferMessage
	{
		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06002487 RID: 9351 RVA: 0x001BFEE8 File Offset: 0x001BE0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PaddockRemoveItemRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06002488 RID: 9352 RVA: 0x001BFEF8 File Offset: 0x001BE0F8
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

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06002489 RID: 9353 RVA: 0x001BFF08 File Offset: 0x001BE108
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

		// Token: 0x0600248A RID: 9354 RVA: 0x001BFF18 File Offset: 0x001BE118
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockRemoveItemRequest()
		{
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x001BFF28 File Offset: 0x001BE128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockRemoveItemRequest(PaddockRemoveItemRequest other)
		{
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x001BFF38 File Offset: 0x001BE138
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockRemoveItemRequest Clone()
		{
			return null;
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x001BFF48 File Offset: 0x001BE148
		// (set) Token: 0x0600248E RID: 9358 RVA: 0x001BFF58 File Offset: 0x001BE158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CellId
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

		// Token: 0x0600248F RID: 9359 RVA: 0x001BFF68 File Offset: 0x001BE168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x001BFF78 File Offset: 0x001BE178
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PaddockRemoveItemRequest other)
		{
			return true;
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x001BFF88 File Offset: 0x001BE188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x001BFF98 File Offset: 0x001BE198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x001BFFA8 File Offset: 0x001BE1A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x001BFFB8 File Offset: 0x001BE1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x001BFFC8 File Offset: 0x001BE1C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x001BFFD8 File Offset: 0x001BE1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PaddockRemoveItemRequest other)
		{
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x001BFFE8 File Offset: 0x001BE1E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x001BFFF8 File Offset: 0x001BE1F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x001C0008 File Offset: 0x001BE208
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PaddockRemoveItemRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					PaddockRemoveItemRequest._parser = new MessageParser<PaddockRemoveItemRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x001C00EC File Offset: 0x001BE2EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FxE65pOWBw0AnFdgUsYn()
		{
			return true;
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x001C00F4 File Offset: 0x001BE2F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PaddockRemoveItemRequest Ph8CCgOWemGTv4oZKUCb()
		{
			return null;
		}

		// Token: 0x04000CFD RID: 3325
		private static readonly MessageParser<PaddockRemoveItemRequest> _parser;

		// Token: 0x04000CFE RID: 3326
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CFF RID: 3327
		public const int CellIdFieldNumber = 1;

		// Token: 0x04000D00 RID: 3328
		private int cellId_;

		// Token: 0x04000D01 RID: 3329
		private static PaddockRemoveItemRequest UQ7tDMOWA5RxVapAAHI0;
	}
}
