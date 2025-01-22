using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CC1 RID: 3265
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitUpdateRequest : IMessage<OutfitUpdateRequest>, IMessage, IEquatable<OutfitUpdateRequest>, IDeepCloneable<OutfitUpdateRequest>, IBufferMessage
	{
		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x06009CF2 RID: 40178 RVA: 0x002821E8 File Offset: 0x002803E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OutfitUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x06009CF3 RID: 40179 RVA: 0x002821F8 File Offset: 0x002803F8
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

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x06009CF4 RID: 40180 RVA: 0x00282208 File Offset: 0x00280408
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

		// Token: 0x06009CF5 RID: 40181 RVA: 0x00282218 File Offset: 0x00280418
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitUpdateRequest()
		{
		}

		// Token: 0x06009CF6 RID: 40182 RVA: 0x00282228 File Offset: 0x00280428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitUpdateRequest(OutfitUpdateRequest other)
		{
		}

		// Token: 0x06009CF7 RID: 40183 RVA: 0x00282238 File Offset: 0x00280438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x06009CF8 RID: 40184 RVA: 0x00282248 File Offset: 0x00280448
		// (set) Token: 0x06009CF9 RID: 40185 RVA: 0x00282258 File Offset: 0x00280458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OutfitUuid
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

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x06009CFA RID: 40186 RVA: 0x00282268 File Offset: 0x00280468
		// (set) Token: 0x06009CFB RID: 40187 RVA: 0x00282278 File Offset: 0x00280478
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Name
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

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x06009CFC RID: 40188 RVA: 0x00282288 File Offset: 0x00280488
		// (set) Token: 0x06009CFD RID: 40189 RVA: 0x00282298 File Offset: 0x00280498
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PictogramId
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

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x06009CFE RID: 40190 RVA: 0x002822A8 File Offset: 0x002804A8
		// (set) Token: 0x06009CFF RID: 40191 RVA: 0x002822B8 File Offset: 0x002804B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Favorite
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06009D00 RID: 40192 RVA: 0x002822C8 File Offset: 0x002804C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009D01 RID: 40193 RVA: 0x002822D8 File Offset: 0x002804D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitUpdateRequest other)
		{
			return true;
		}

		// Token: 0x06009D02 RID: 40194 RVA: 0x002822E8 File Offset: 0x002804E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009D03 RID: 40195 RVA: 0x002822F8 File Offset: 0x002804F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009D04 RID: 40196 RVA: 0x00282308 File Offset: 0x00280508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009D05 RID: 40197 RVA: 0x00282318 File Offset: 0x00280518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009D06 RID: 40198 RVA: 0x00282328 File Offset: 0x00280528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009D07 RID: 40199 RVA: 0x00282338 File Offset: 0x00280538
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitUpdateRequest other)
		{
		}

		// Token: 0x06009D08 RID: 40200 RVA: 0x00282348 File Offset: 0x00280548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009D09 RID: 40201 RVA: 0x00282358 File Offset: 0x00280558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009D0A RID: 40202 RVA: 0x00282368 File Offset: 0x00280568
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitUpdateRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
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
					OutfitUpdateRequest._parser = new MessageParser<OutfitUpdateRequest>(() => null);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06009D0B RID: 40203 RVA: 0x00282434 File Offset: 0x00280634
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kvZEewJ4o9nRTwlkuD10()
		{
			return true;
		}

		// Token: 0x06009D0C RID: 40204 RVA: 0x0028243C File Offset: 0x0028063C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitUpdateRequest Ag4ykwJ41v8eEFYiW23m()
		{
			return null;
		}

		// Token: 0x04003A2A RID: 14890
		private static readonly MessageParser<OutfitUpdateRequest> _parser;

		// Token: 0x04003A2B RID: 14891
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A2C RID: 14892
		public const int OutfitUuidFieldNumber = 1;

		// Token: 0x04003A2D RID: 14893
		private string outfitUuid_;

		// Token: 0x04003A2E RID: 14894
		public const int NameFieldNumber = 2;

		// Token: 0x04003A2F RID: 14895
		private string name_;

		// Token: 0x04003A30 RID: 14896
		public const int PictogramIdFieldNumber = 3;

		// Token: 0x04003A31 RID: 14897
		private int pictogramId_;

		// Token: 0x04003A32 RID: 14898
		public const int FavoriteFieldNumber = 4;

		// Token: 0x04003A33 RID: 14899
		private bool favorite_;

		// Token: 0x04003A34 RID: 14900
		internal static OutfitUpdateRequest vUkDjoJ4vEObivOYpq3F;
	}
}
