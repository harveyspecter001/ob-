using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x02000485 RID: 1157
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagFurnitureRequest : IMessage<HavenBagFurnitureRequest>, IMessage, IEquatable<HavenBagFurnitureRequest>, IDeepCloneable<HavenBagFurnitureRequest>, IBufferMessage
	{
		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06003763 RID: 14179 RVA: 0x001DF33C File Offset: 0x001DD53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HavenBagFurnitureRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06003764 RID: 14180 RVA: 0x001DF34C File Offset: 0x001DD54C
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

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06003765 RID: 14181 RVA: 0x001DF35C File Offset: 0x001DD55C
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

		// Token: 0x06003766 RID: 14182 RVA: 0x001DF36C File Offset: 0x001DD56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagFurnitureRequest()
		{
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x001DF37C File Offset: 0x001DD57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagFurnitureRequest(HavenBagFurnitureRequest other)
		{
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x001DF38C File Offset: 0x001DD58C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagFurnitureRequest Clone()
		{
			return null;
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06003769 RID: 14185 RVA: 0x001DF39C File Offset: 0x001DD59C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<Element> Furniture
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600376A RID: 14186 RVA: 0x001DF3AC File Offset: 0x001DD5AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x001DF3BC File Offset: 0x001DD5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagFurnitureRequest other)
		{
			return true;
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x001DF3CC File Offset: 0x001DD5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x001DF3DC File Offset: 0x001DD5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x001DF3EC File Offset: 0x001DD5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600376F RID: 14191 RVA: 0x001DF3FC File Offset: 0x001DD5FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x001DF40C File Offset: 0x001DD60C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x001DF41C File Offset: 0x001DD61C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagFurnitureRequest other)
		{
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x001DF42C File Offset: 0x001DD62C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x001DF43C File Offset: 0x001DD63C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x001DF44C File Offset: 0x001DD64C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagFurnitureRequest()
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
						goto IL_AF;
					case 2:
						HavenBagFurnitureRequest._parser = new MessageParser<HavenBagFurnitureRequest>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 4;
						continue;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
				}
				IL_AF:
				HavenBagFurnitureRequest._repeated_furniture_codec = FieldCodec.ForMessage<Element>(10U, m74H6HmG5VAhiQF5gXhT.XVInXhlssT(m74H6HmG5VAhiQF5gXhT.tmkmGyQW1DI));
				num = 3;
			}
		}

		// Token: 0x06003775 RID: 14197 RVA: 0x001DF540 File Offset: 0x001DD740
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FwEqEAOwsUOpipsHVwEX()
		{
			return true;
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x001DF548 File Offset: 0x001DD748
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagFurnitureRequest cguyHCOwd5763N6CNdmR()
		{
			return null;
		}

		// Token: 0x04001364 RID: 4964
		private static readonly MessageParser<HavenBagFurnitureRequest> _parser;

		// Token: 0x04001365 RID: 4965
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001366 RID: 4966
		public const int FurnitureFieldNumber = 1;

		// Token: 0x04001367 RID: 4967
		private static readonly FieldCodec<Element> _repeated_furniture_codec;

		// Token: 0x04001368 RID: 4968
		private readonly RepeatedField<Element> furniture_;

		// Token: 0x04001369 RID: 4969
		internal static HavenBagFurnitureRequest igCMplOwgy2QVt2bLi8x;
	}
}
