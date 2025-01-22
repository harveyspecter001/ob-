using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CCD RID: 3277
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitRemoveResponse : IMessage<OutfitRemoveResponse>, IMessage, IEquatable<OutfitRemoveResponse>, IDeepCloneable<OutfitRemoveResponse>, IBufferMessage
	{
		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x06009DA0 RID: 40352 RVA: 0x00282F60 File Offset: 0x00281160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OutfitRemoveResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x06009DA1 RID: 40353 RVA: 0x00282F70 File Offset: 0x00281170
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

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x06009DA2 RID: 40354 RVA: 0x00282F80 File Offset: 0x00281180
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

		// Token: 0x06009DA3 RID: 40355 RVA: 0x00282F90 File Offset: 0x00281190
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitRemoveResponse()
		{
		}

		// Token: 0x06009DA4 RID: 40356 RVA: 0x00282FA0 File Offset: 0x002811A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitRemoveResponse(OutfitRemoveResponse other)
		{
		}

		// Token: 0x06009DA5 RID: 40357 RVA: 0x00282FB0 File Offset: 0x002811B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitRemoveResponse Clone()
		{
			return null;
		}

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x06009DA6 RID: 40358 RVA: 0x00282FC0 File Offset: 0x002811C0
		// (set) Token: 0x06009DA7 RID: 40359 RVA: 0x00282FD0 File Offset: 0x002811D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Success
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

		// Token: 0x06009DA8 RID: 40360 RVA: 0x00282FE0 File Offset: 0x002811E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009DA9 RID: 40361 RVA: 0x00282FF0 File Offset: 0x002811F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitRemoveResponse other)
		{
			return true;
		}

		// Token: 0x06009DAA RID: 40362 RVA: 0x00283000 File Offset: 0x00281200
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009DAB RID: 40363 RVA: 0x00283010 File Offset: 0x00281210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009DAC RID: 40364 RVA: 0x00283020 File Offset: 0x00281220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009DAD RID: 40365 RVA: 0x00283030 File Offset: 0x00281230
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009DAE RID: 40366 RVA: 0x00283040 File Offset: 0x00281240
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009DAF RID: 40367 RVA: 0x00283050 File Offset: 0x00281250
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitRemoveResponse other)
		{
		}

		// Token: 0x06009DB0 RID: 40368 RVA: 0x00283060 File Offset: 0x00281260
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009DB1 RID: 40369 RVA: 0x00283070 File Offset: 0x00281270
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009DB2 RID: 40370 RVA: 0x00283080 File Offset: 0x00281280
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitRemoveResponse()
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
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						continue;
					case 4:
						OutfitRemoveResponse._parser = new MessageParser<OutfitRemoveResponse>(() => null);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					break;
				}
				IL_73:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
				continue;
				goto IL_73;
			}
		}

		// Token: 0x06009DB3 RID: 40371 RVA: 0x00283150 File Offset: 0x00281350
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fKR8y9J4TkbSRqhk9GTv()
		{
			return true;
		}

		// Token: 0x06009DB4 RID: 40372 RVA: 0x00283158 File Offset: 0x00281358
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitRemoveResponse ArJ1ShJ4pXk2BQlhQWVi()
		{
			return null;
		}

		// Token: 0x04003A66 RID: 14950
		private static readonly MessageParser<OutfitRemoveResponse> _parser;

		// Token: 0x04003A67 RID: 14951
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A68 RID: 14952
		public const int SuccessFieldNumber = 1;

		// Token: 0x04003A69 RID: 14953
		private bool success_;

		// Token: 0x04003A6A RID: 14954
		internal static OutfitRemoveResponse pa9RCcJ47wIp7QwZPni0;
	}
}
