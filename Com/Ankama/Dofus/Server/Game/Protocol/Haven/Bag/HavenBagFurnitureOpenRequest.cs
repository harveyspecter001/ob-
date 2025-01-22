using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x02000483 RID: 1155
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagFurnitureOpenRequest : IMessage<HavenBagFurnitureOpenRequest>, IMessage, IEquatable<HavenBagFurnitureOpenRequest>, IDeepCloneable<HavenBagFurnitureOpenRequest>, IBufferMessage
	{
		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x0600374B RID: 14155 RVA: 0x001DF148 File Offset: 0x001DD348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HavenBagFurnitureOpenRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x0600374C RID: 14156 RVA: 0x001DF158 File Offset: 0x001DD358
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

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x0600374D RID: 14157 RVA: 0x001DF168 File Offset: 0x001DD368
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

		// Token: 0x0600374E RID: 14158 RVA: 0x001DF178 File Offset: 0x001DD378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagFurnitureOpenRequest()
		{
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x001DF188 File Offset: 0x001DD388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagFurnitureOpenRequest(HavenBagFurnitureOpenRequest other)
		{
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x001DF198 File Offset: 0x001DD398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagFurnitureOpenRequest Clone()
		{
			return null;
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x001DF1A8 File Offset: 0x001DD3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x001DF1B8 File Offset: 0x001DD3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagFurnitureOpenRequest other)
		{
			return true;
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x001DF1C8 File Offset: 0x001DD3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x001DF1D8 File Offset: 0x001DD3D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x001DF1E8 File Offset: 0x001DD3E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x001DF1F8 File Offset: 0x001DD3F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003757 RID: 14167 RVA: 0x001DF208 File Offset: 0x001DD408
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003758 RID: 14168 RVA: 0x001DF218 File Offset: 0x001DD418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagFurnitureOpenRequest other)
		{
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x001DF228 File Offset: 0x001DD428
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x001DF238 File Offset: 0x001DD438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x001DF248 File Offset: 0x001DD448
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagFurnitureOpenRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					HavenBagFurnitureOpenRequest._parser = new MessageParser<HavenBagFurnitureOpenRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x001DF32C File Offset: 0x001DD52C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vCOgddOwJHQ8EcbAy6c9()
		{
			return true;
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x001DF334 File Offset: 0x001DD534
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagFurnitureOpenRequest VrNgHlOwGSsFR6ZyEHaa()
		{
			return null;
		}

		// Token: 0x0400135F RID: 4959
		private static readonly MessageParser<HavenBagFurnitureOpenRequest> _parser;

		// Token: 0x04001360 RID: 4960
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001361 RID: 4961
		internal static HavenBagFurnitureOpenRequest gCoS7hOwO2Y3VMFUT8cR;
	}
}
