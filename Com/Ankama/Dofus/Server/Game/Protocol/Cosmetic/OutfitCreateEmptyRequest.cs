using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CC5 RID: 3269
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitCreateEmptyRequest : IMessage<OutfitCreateEmptyRequest>, IMessage, IEquatable<OutfitCreateEmptyRequest>, IDeepCloneable<OutfitCreateEmptyRequest>, IBufferMessage
	{
		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x06009D2C RID: 40236 RVA: 0x00282640 File Offset: 0x00280840
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<OutfitCreateEmptyRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x06009D2D RID: 40237 RVA: 0x00282650 File Offset: 0x00280850
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

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x06009D2E RID: 40238 RVA: 0x00282660 File Offset: 0x00280860
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

		// Token: 0x06009D2F RID: 40239 RVA: 0x00282670 File Offset: 0x00280870
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitCreateEmptyRequest()
		{
		}

		// Token: 0x06009D30 RID: 40240 RVA: 0x00282680 File Offset: 0x00280880
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitCreateEmptyRequest(OutfitCreateEmptyRequest other)
		{
		}

		// Token: 0x06009D31 RID: 40241 RVA: 0x00282690 File Offset: 0x00280890
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitCreateEmptyRequest Clone()
		{
			return null;
		}

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x06009D32 RID: 40242 RVA: 0x002826A0 File Offset: 0x002808A0
		// (set) Token: 0x06009D33 RID: 40243 RVA: 0x002826B0 File Offset: 0x002808B0
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

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x06009D34 RID: 40244 RVA: 0x002826C0 File Offset: 0x002808C0
		// (set) Token: 0x06009D35 RID: 40245 RVA: 0x002826D0 File Offset: 0x002808D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x06009D36 RID: 40246 RVA: 0x002826E0 File Offset: 0x002808E0
		// (set) Token: 0x06009D37 RID: 40247 RVA: 0x002826F0 File Offset: 0x002808F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FaceId
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

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x06009D38 RID: 40248 RVA: 0x00282700 File Offset: 0x00280900
		// (set) Token: 0x06009D39 RID: 40249 RVA: 0x00282710 File Offset: 0x00280910
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ColorPalette ColorPalette
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

		// Token: 0x06009D3A RID: 40250 RVA: 0x00282720 File Offset: 0x00280920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009D3B RID: 40251 RVA: 0x00282730 File Offset: 0x00280930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitCreateEmptyRequest other)
		{
			return true;
		}

		// Token: 0x06009D3C RID: 40252 RVA: 0x00282740 File Offset: 0x00280940
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009D3D RID: 40253 RVA: 0x00282750 File Offset: 0x00280950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009D3E RID: 40254 RVA: 0x00282760 File Offset: 0x00280960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009D3F RID: 40255 RVA: 0x00282770 File Offset: 0x00280970
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009D40 RID: 40256 RVA: 0x00282780 File Offset: 0x00280980
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009D41 RID: 40257 RVA: 0x00282790 File Offset: 0x00280990
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitCreateEmptyRequest other)
		{
		}

		// Token: 0x06009D42 RID: 40258 RVA: 0x002827A0 File Offset: 0x002809A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009D43 RID: 40259 RVA: 0x002827B0 File Offset: 0x002809B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009D44 RID: 40260 RVA: 0x002827C0 File Offset: 0x002809C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitCreateEmptyRequest()
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
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					OutfitCreateEmptyRequest._parser = new MessageParser<OutfitCreateEmptyRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
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
				break;
			}
		}

		// Token: 0x06009D45 RID: 40261 RVA: 0x002828A4 File Offset: 0x00280AA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SycvJTJ4LrDoit4ceJDR()
		{
			return true;
		}

		// Token: 0x06009D46 RID: 40262 RVA: 0x002828AC File Offset: 0x00280AAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitCreateEmptyRequest wOQdqnJ4WoZTlKZu4Zx0()
		{
			return null;
		}

		// Token: 0x04003A3E RID: 14910
		private static readonly MessageParser<OutfitCreateEmptyRequest> _parser;

		// Token: 0x04003A3F RID: 14911
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A40 RID: 14912
		public const int NameFieldNumber = 1;

		// Token: 0x04003A41 RID: 14913
		private string name_;

		// Token: 0x04003A42 RID: 14914
		public const int PictogramIdFieldNumber = 2;

		// Token: 0x04003A43 RID: 14915
		private int pictogramId_;

		// Token: 0x04003A44 RID: 14916
		public const int FaceIdFieldNumber = 3;

		// Token: 0x04003A45 RID: 14917
		private int faceId_;

		// Token: 0x04003A46 RID: 14918
		public const int ColorPaletteFieldNumber = 4;

		// Token: 0x04003A47 RID: 14919
		private ColorPalette colorPalette_;

		// Token: 0x04003A48 RID: 14920
		private static OutfitCreateEmptyRequest DQoY2kJ46XvfbW2uhoYm;
	}
}
