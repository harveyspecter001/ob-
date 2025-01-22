using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x02000487 RID: 1159
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagFurnitureCloseRequest : IMessage<HavenBagFurnitureCloseRequest>, IMessage, IEquatable<HavenBagFurnitureCloseRequest>, IDeepCloneable<HavenBagFurnitureCloseRequest>, IBufferMessage
	{
		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x0600377C RID: 14204 RVA: 0x001DF550 File Offset: 0x001DD750
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HavenBagFurnitureCloseRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x0600377D RID: 14205 RVA: 0x001DF560 File Offset: 0x001DD760
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

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x0600377E RID: 14206 RVA: 0x001DF570 File Offset: 0x001DD770
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

		// Token: 0x0600377F RID: 14207 RVA: 0x001DF580 File Offset: 0x001DD780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagFurnitureCloseRequest()
		{
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x001DF590 File Offset: 0x001DD790
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagFurnitureCloseRequest(HavenBagFurnitureCloseRequest other)
		{
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x001DF5A0 File Offset: 0x001DD7A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagFurnitureCloseRequest Clone()
		{
			return null;
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x001DF5B0 File Offset: 0x001DD7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x001DF5C0 File Offset: 0x001DD7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagFurnitureCloseRequest other)
		{
			return true;
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x001DF5D0 File Offset: 0x001DD7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x001DF5E0 File Offset: 0x001DD7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x001DF5F0 File Offset: 0x001DD7F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x001DF600 File Offset: 0x001DD800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x001DF610 File Offset: 0x001DD810
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x001DF620 File Offset: 0x001DD820
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagFurnitureCloseRequest other)
		{
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x001DF630 File Offset: 0x001DD830
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x001DF640 File Offset: 0x001DD840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x001DF650 File Offset: 0x001DD850
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagFurnitureCloseRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				case 3:
					HavenBagFurnitureCloseRequest._parser = new MessageParser<HavenBagFurnitureCloseRequest>(() => null);
					num2 = 4;
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x001DF71C File Offset: 0x001DD91C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qR9oaqOw2R0X05jSwLsS()
		{
			return true;
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x001DF724 File Offset: 0x001DD924
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagFurnitureCloseRequest uXKWTBOwEaAE7PR8HN1s()
		{
			return null;
		}

		// Token: 0x0400136C RID: 4972
		private static readonly MessageParser<HavenBagFurnitureCloseRequest> _parser;

		// Token: 0x0400136D RID: 4973
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400136E RID: 4974
		private static HavenBagFurnitureCloseRequest wOWVcaOw9rkmH4tlWjqC;
	}
}
