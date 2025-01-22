using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage
{
	// Token: 0x020000E4 RID: 228
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RemoveTagStorageRequest : IMessage<RemoveTagStorageRequest>, IMessage, IEquatable<RemoveTagStorageRequest>, IDeepCloneable<RemoveTagStorageRequest>, IBufferMessage
	{
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x00193EEC File Offset: 0x001920EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<RemoveTagStorageRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00193EFC File Offset: 0x001920FC
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

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x00193F0C File Offset: 0x0019210C
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

		// Token: 0x06000A43 RID: 2627 RVA: 0x00193F1C File Offset: 0x0019211C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveTagStorageRequest()
		{
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00193F2C File Offset: 0x0019212C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveTagStorageRequest(RemoveTagStorageRequest other)
		{
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00193F3C File Offset: 0x0019213C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveTagStorageRequest Clone()
		{
			return null;
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00193F4C File Offset: 0x0019214C
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x00193F5C File Offset: 0x0019215C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TagStorageUuid
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

		// Token: 0x06000A48 RID: 2632 RVA: 0x00193F6C File Offset: 0x0019216C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00193F7C File Offset: 0x0019217C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(RemoveTagStorageRequest other)
		{
			return true;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00193F8C File Offset: 0x0019218C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00193F9C File Offset: 0x0019219C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00193FAC File Offset: 0x001921AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00193FBC File Offset: 0x001921BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00193FCC File Offset: 0x001921CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00193FDC File Offset: 0x001921DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(RemoveTagStorageRequest other)
		{
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00193FEC File Offset: 0x001921EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00193FFC File Offset: 0x001921FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0019400C File Offset: 0x0019220C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static RemoveTagStorageRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				RemoveTagStorageRequest._parser = new MessageParser<RemoveTagStorageRequest>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x001940F0 File Offset: 0x001922F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool R4ymy5OkzjrdZlBTCU1H()
		{
			return true;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x001940F8 File Offset: 0x001922F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RemoveTagStorageRequest HwVYG4Olf5EtZF8rIQw2()
		{
			return null;
		}

		// Token: 0x040003CC RID: 972
		private static readonly MessageParser<RemoveTagStorageRequest> _parser;

		// Token: 0x040003CD RID: 973
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003CE RID: 974
		public const int TagStorageUuidFieldNumber = 1;

		// Token: 0x040003CF RID: 975
		private string tagStorageUuid_;

		// Token: 0x040003D0 RID: 976
		private static RemoveTagStorageRequest UZddf4OkF0EDKG5f1Xay;
	}
}
