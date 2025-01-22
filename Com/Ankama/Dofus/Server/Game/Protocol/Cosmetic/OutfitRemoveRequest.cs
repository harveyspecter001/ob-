using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CCB RID: 3275
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitRemoveRequest : IMessage<OutfitRemoveRequest>, IMessage, IEquatable<OutfitRemoveRequest>, IDeepCloneable<OutfitRemoveRequest>, IBufferMessage
	{
		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x06009D86 RID: 40326 RVA: 0x00282D64 File Offset: 0x00280F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OutfitRemoveRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x06009D87 RID: 40327 RVA: 0x00282D74 File Offset: 0x00280F74
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

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x06009D88 RID: 40328 RVA: 0x00282D84 File Offset: 0x00280F84
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

		// Token: 0x06009D89 RID: 40329 RVA: 0x00282D94 File Offset: 0x00280F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitRemoveRequest()
		{
		}

		// Token: 0x06009D8A RID: 40330 RVA: 0x00282DA4 File Offset: 0x00280FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitRemoveRequest(OutfitRemoveRequest other)
		{
		}

		// Token: 0x06009D8B RID: 40331 RVA: 0x00282DB4 File Offset: 0x00280FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitRemoveRequest Clone()
		{
			return null;
		}

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x06009D8C RID: 40332 RVA: 0x00282DC4 File Offset: 0x00280FC4
		// (set) Token: 0x06009D8D RID: 40333 RVA: 0x00282DD4 File Offset: 0x00280FD4
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

		// Token: 0x06009D8E RID: 40334 RVA: 0x00282DE4 File Offset: 0x00280FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009D8F RID: 40335 RVA: 0x00282DF4 File Offset: 0x00280FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitRemoveRequest other)
		{
			return true;
		}

		// Token: 0x06009D90 RID: 40336 RVA: 0x00282E04 File Offset: 0x00281004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009D91 RID: 40337 RVA: 0x00282E14 File Offset: 0x00281014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009D92 RID: 40338 RVA: 0x00282E24 File Offset: 0x00281024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009D93 RID: 40339 RVA: 0x00282E34 File Offset: 0x00281034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009D94 RID: 40340 RVA: 0x00282E44 File Offset: 0x00281044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009D95 RID: 40341 RVA: 0x00282E54 File Offset: 0x00281054
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitRemoveRequest other)
		{
		}

		// Token: 0x06009D96 RID: 40342 RVA: 0x00282E64 File Offset: 0x00281064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009D97 RID: 40343 RVA: 0x00282E74 File Offset: 0x00281074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009D98 RID: 40344 RVA: 0x00282E84 File Offset: 0x00281084
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitRemoveRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				case 2:
					OutfitRemoveRequest._parser = new MessageParser<OutfitRemoveRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06009D99 RID: 40345 RVA: 0x00282F50 File Offset: 0x00281150
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool osTMXNJ4wY5gPJNuFwCj()
		{
			return true;
		}

		// Token: 0x06009D9A RID: 40346 RVA: 0x00282F58 File Offset: 0x00281158
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitRemoveRequest TMF4ecJ4QasX9mZE1UKh()
		{
			return null;
		}

		// Token: 0x04003A5F RID: 14943
		private static readonly MessageParser<OutfitRemoveRequest> _parser;

		// Token: 0x04003A60 RID: 14944
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A61 RID: 14945
		public const int OutfitUuidFieldNumber = 1;

		// Token: 0x04003A62 RID: 14946
		private string outfitUuid_;

		// Token: 0x04003A63 RID: 14947
		internal static OutfitRemoveRequest aOElLaJ4tLUlrLEI4pLp;
	}
}
